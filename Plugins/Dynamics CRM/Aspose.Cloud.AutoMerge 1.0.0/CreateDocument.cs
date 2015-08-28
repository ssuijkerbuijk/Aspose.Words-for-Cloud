using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Aspose.Cloud.AutoMerge
{
    public class CreateDocument : CodeActivity
    {
        [Input("Enable Logging")]
        [Default("False")]
        public InArgument<bool> EnableLogging { get; set; }

        [Input("Product URI")]
        [Default(@"http://api.aspose.com/v1.1")]
        public InArgument<string> ProductUri { get; set; }

        [Input("App SID")]
        public InArgument<string> AppSID { get; set; }

        [Input("App Key")]
        public InArgument<string> AppKey { get; set; }

        [Input("Document Template")]
        [ReferenceTarget("aspose_documenttemplate")]
        public InArgument<EntityReference> DocumentTemplateId { get; set; }

        [Input("Delete Template From Cloud Storage")]
        [Default("True")]
        public InArgument<bool> DeleteTemplate { get; set; }

        [Input("Delete Generated Document From Cloud Storage")]
        [Default("True")]
        public InArgument<bool> DeleteDocument { get; set; }
        
        [Output("Attachment")]
        [ReferenceTarget("annotation")]
        public OutArgument<EntityReference> OutputAttachmentId { get; set; }

        protected override void Execute(CodeActivityContext executionContext)
        {
            EntityReference DocumentTemplateIdValue = DocumentTemplateId.Get(executionContext);
            Boolean EnableLoggingValue = EnableLogging.Get(executionContext);
            string ProductUriValue = ProductUri.Get(executionContext);
            string AppSIDValue = AppSID.Get(executionContext);
            string AppKeyValue = AppKey.Get(executionContext);
            Boolean DeleteTemplateValue = DeleteTemplate.Get(executionContext);
            Boolean DeleteDocumentValue = DeleteDocument.Get(executionContext);
            OutputAttachmentId.Set(executionContext, new EntityReference("annotation", Guid.Empty));
            CloudAppConfig config = new CloudAppConfig();
            config.ProductUri = ProductUriValue;
            config.AppSID = AppSIDValue;
            config.AppKey = AppKeyValue;
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            try
            {
                if (EnableLoggingValue)
                    Log("WorkFlow Started",service);
               
                string PrimaryEntityName = context.PrimaryEntityName;
                Guid PrimaryEntityId = context.PrimaryEntityId;
                if (EnableLoggingValue)
                    Log("Retrieving Attachment From Template", service);
                QueryExpression RetrieveNoteQuery = new QueryExpression("annotation");
                RetrieveNoteQuery.ColumnSet = new ColumnSet(new string[] { "filename", "documentbody", "mimetype" });
                RetrieveNoteQuery.Criteria.AddCondition(new ConditionExpression("objectid", ConditionOperator.Equal, DocumentTemplateIdValue.Id));
                EntityCollection TemplateAttachments = service.RetrieveMultiple(RetrieveNoteQuery);
                if (EnableLoggingValue)
                    Log("Attachment Retrieved Successfully", service);

                if (TemplateAttachments != null && TemplateAttachments.Entities.Count > 0)
                {
                    Entity AttachmentTemplate = TemplateAttachments.Entities[0];
                    if (AttachmentTemplate.Contains("mimetype") && AttachmentTemplate.Contains("documentbody"))
                    {
                        string FileName = "";
                        if (AttachmentTemplate.Contains("filename"))
                            FileName = AttachmentTemplate["filename"].ToString();
                        config.FileName = FileName;
                        byte[] DocumentBody = Convert.FromBase64String(AttachmentTemplate["documentbody"].ToString());
                        MemoryStream fileStream = new MemoryStream(DocumentBody);

                        if (EnableLoggingValue)
                            Log("Upload Template on Storage", service);
                        UploadFileOnStorage(config, fileStream);

                        if (EnableLoggingValue)
                            Log("Get Fields List", service);
                        string[] Fields = GetFieldsName(config).ToArray();

                        if (EnableLoggingValue)
                            Log("Retrieving Fields Values From CRM", service);
                        Entity PrimaryEntity = service.Retrieve(PrimaryEntityName, PrimaryEntityId, new ColumnSet(Fields));
                        string[] Values = new string[Fields.Length];
                        if (PrimaryEntity != null)
                        {
                            for (int i = 0; i < Fields.Length; i++)
                            {
                                if (PrimaryEntity.Contains(Fields[i]))
                                {
                                    if (PrimaryEntity[Fields[i]].GetType() == typeof(OptionSetValue))
                                        Values[i] = PrimaryEntity.FormattedValues[Fields[i]].ToString();
                                    else if (PrimaryEntity[Fields[i]].GetType() == typeof(EntityReference))
                                        Values[i] = ((EntityReference)PrimaryEntity[Fields[i]]).Name;
                                    else
                                        Values[i] = PrimaryEntity[Fields[i]].ToString();
                                }
                                else
                                    Values[i] = "";
                            }
                        }

                        if (EnableLoggingValue)
                            Log("Generating Xml", service);
                        string Xml = GenerateXML(Fields, Values);

                        if (EnableLoggingValue)
                            Log("Executing MailMerge", service);
                        string OutputFileName = ExecuteMailMerge(config, Xml);

                        if (EnableLoggingValue)
                            Log("Downloading File From Cloud", service);
                        MemoryStream OutputFile = DownloadFile(config, OutputFileName);

                        if (EnableLoggingValue)
                            Log("Generating CRM Attachment", service);
                        byte[] byteData = OutputFile.ToArray();
                        string encodedData = System.Convert.ToBase64String(byteData);
                        Entity NewNote = new Entity("annotation");
                        NewNote.Attributes.Add("objectid", new EntityReference(PrimaryEntityName, PrimaryEntityId));
                        NewNote.Attributes.Add("subject", FileName);
                        NewNote.Attributes.Add("documentbody", encodedData);
                        NewNote.Attributes.Add("mimetype", @"application/vnd.openxmlformats-officedocument.wordprocessingml.document");
                        NewNote.Attributes.Add("notetext", "Document Created using Aspose Cloud");
                        NewNote.Attributes.Add("filename", FileName);
                        Guid NewNoteId = service.Create(NewNote);

                        if (EnableLoggingValue)
                            Log("Removing Documents from Storage", service);
                        if (DeleteTemplateValue)
                        {
                            DeleteDocumentFromStorage(config, FileName);
                        }
                        if (DeleteDocumentValue)
                        {
                            DeleteDocumentFromStorage(config, OutputFileName);
                        }

                        OutputAttachmentId.Set(executionContext, new EntityReference("annotation", NewNoteId));

                    }
                    else
                    {
                        if (EnableLoggingValue)
                            Log("Attachment Doesnot contain any document", service);
                    }

                }
                else
                {
                    if (EnableLoggingValue)
                        Log("No Attachments in the Template Provided", service);
                }

                if (EnableLoggingValue)
                    Log("Workflow Executed Successfully", service);
            }
            catch (Exception ex)
            {
                Log(ex.Message, service);
                throw ex;
            }
        }
        private void DeleteDocumentFromStorage(CloudAppConfig Config, string FileName)
        {
            string URIRequest = Config.ProductUri + "/storage/file/" + FileName;
            string URISigned = Sign(URIRequest, Config.AppSID, Config.AppKey);
            ProcessCommand(URISigned, "DELETE");
        }

        private MemoryStream DownloadFile(CloudAppConfig Config, string OutputFileName)
        {
            try
            {
                string URIRequest = Config.ProductUri + "/words/" + OutputFileName + "?format=" + "Docx";
                string URISigned = Sign(URIRequest, Config.AppSID, Config.AppKey);
                using (Stream responseStream = ProcessCommand(URISigned, "GET"))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        responseStream.CopyTo(memoryStream);
                        return memoryStream;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CopyStream(Stream responseStream, Stream memoryStream)
        {
            try
            {
                byte[] buffer = new byte[8 * 1024];
                int len;
                while ((len = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    memoryStream.Write(buffer, 0, len);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string ExecuteMailMerge(CloudAppConfig Config, string Xml)
        {
            try
            {
                string URIRequest = Config.ProductUri + "/words/" + Config.FileName + "/executeMailMerge";
                string URISigned = Sign(URIRequest, Config.AppSID, Config.AppKey);

                string outputFileName = null;

                using (Stream responseStream = ProcessCommand(URISigned, "POST", Xml, "xml"))
                {
                    string strResponse = null;

                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        strResponse = reader.ReadToEnd();
                    }

                    using (MemoryStream ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(strResponse)))
                    {
                        XPathDocument xPathDoc = new XPathDocument(ms);
                        XPathNavigator navigator = xPathDoc.CreateNavigator();

                        //get File Name
                        XPathNodeIterator nodes = navigator.Select("/SaaSposeResponse/Document/FileName");
                        nodes.MoveNext();
                        outputFileName = nodes.Current.InnerXml;
                        return outputFileName;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Stream ProcessCommand(string strURI, string strHttpCommand, string strContent, string ContentType = "xml")
        {
            try
            {
                byte[] arr = System.Text.Encoding.UTF8.GetBytes(strContent);

                Uri address = new Uri(strURI);
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(address);
                request.Method = strHttpCommand;
                if (ContentType.ToLower() == "xml")
                    request.ContentType = "application/xml";
                else
                    request.ContentType = "application/json";

                request.ContentLength = arr.Length;

                Stream dataStream = request.GetRequestStream();
                dataStream.Write(arr, 0, arr.Length);
                dataStream.Close();

                System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
                return response.GetResponseStream();
            }
            catch (System.Net.WebException webex)
            {
                throw new Exception(webex.Message);
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        private string GenerateXML(string[] Fields, string[] Values)
        {
            string strXML = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><Fields></Fields>";
            XDocument xdoc = XDocument.Parse(strXML);
            XElement m = xdoc.XPathSelectElement("//Fields");
            for (int i = 0; i < Fields.Length; i++)
            {
                XElement xElement = new XElement(Fields[i], Values[i]);
                m.Add(xElement);
            }
            return xdoc.ToString();
        }

        private List<string> GetFieldsName(CloudAppConfig Config)
        {
            try
            {

                List<string> FieldsName = new List<string>();
                string URIRequest = Config.ProductUri + "/words/" + Config.FileName + "/mailMergeFieldNames";
                string URISigned = Sign(URIRequest, Config.AppSID, Config.AppKey);
                StreamReader reader = new StreamReader(ProcessCommand(URISigned, "GET"));
                string strJSON = reader.ReadToEnd();
                var jsonReader = JsonReaderWriterFactory.CreateJsonReader(Encoding.UTF8.GetBytes(strJSON), new System.Xml.XmlDictionaryReaderQuotas());
                var root = XElement.Load(jsonReader);
                IEnumerable<XElement> MainList = root.XPathSelectElements("//FieldNames/Names/item");
                foreach (XElement el in MainList)
                    FieldsName.Add(el.Value);
                return FieldsName;
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        private Stream ProcessCommand(string URISigned, string HttpCommand)
        {
            try
            {
                Uri address = new Uri(URISigned);
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(address);
                request.Method = HttpCommand;
                request.ContentType = "application/json";

                request.ContentLength = 0;
                System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
                return response.GetResponseStream();
            }
            catch (System.Net.WebException webex)
            {
                throw new Exception(webex.Message);
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }

        }

        private void UploadFileOnStorage(CloudAppConfig Config, MemoryStream fileStream)
        {
            string URIRequest = Config.ProductUri + "/storage/file/" + Config.FileName;

            string URISigned = Sign(URIRequest, Config.AppSID, Config.AppKey);

            try
            {
                System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(URISigned);
                req.Method = "PUT";
                req.ContentType = "application/x-www-form-urlencoded";
                req.AllowWriteStreamBuffering = true;

                using (System.IO.Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(fileStream.ToArray(), 0, (int)fileStream.Length);
                }
                string statusCode = null;

                using (System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)req.GetResponse())
                {
                    statusCode = response.StatusCode.ToString();
                }
            }
            catch (System.Net.WebException webex)
            {
                throw new Exception(webex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string Sign(string URIRequest, string AppSIDValue, string AppKeyValue)
        {
            try
            {
                // Add appSID parameter.
                UriBuilder builder = new UriBuilder(URIRequest);
                if (builder.Query != null && builder.Query.Length > 1)
                    builder.Query = builder.Query.Substring(1) + "&appSID=" + AppSIDValue;
                else
                    builder.Query = "appSID=" + AppSIDValue;
                // Remove final slash here as it can be added automatically.
                builder.Path = builder.Path.TrimEnd('/');
                // Compute the hash.

                byte[] privateKey = System.Text.Encoding.UTF8.GetBytes(AppKeyValue);

                System.Security.Cryptography.HMACSHA1 algorithm = new System.Security.Cryptography.HMACSHA1(privateKey);
                //System.Text.ASCIIEncoding
                byte[] sequence = System.Text.ASCIIEncoding.ASCII.GetBytes(builder.Uri.AbsoluteUri);
                byte[] hash = algorithm.ComputeHash(sequence);
                string signature = Convert.ToBase64String(hash);
                // Remove invalid symbols.
                signature = signature.TrimEnd('=');
                //signature = System.Web.HttpUtility.UrlEncode(signature);
                signature = System.Uri.EscapeDataString(signature);
                // Convert codes to upper case as they can be updated automatically.
                signature = System.Text.RegularExpressions.Regex.Replace(signature, "%[0-9a-f]{2}", e => e.Value.ToUpper());
                //signature = System.Text.RegularExpressions.Regex.Replace(signature, "%[0-9a-f]{2}", delegate(string e){ e.Value.ToUpper()});
                // Add the signature to query string.
                return string.Format("{0}&signature={1}", builder.Uri.AbsoluteUri, signature);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void Log(string Message, IOrganizationService service)
        {
            //Entity LogEntry = new Entity("Aspose_AsposeLog");
            //LogEntry.Attributes.Add("Name", "Aspose.CLoud.AutoMerge.CreateDocument");
            //LogEntry.Attributes.Add("Description", Message);
            //service.Create(LogEntry);
        }
    }
    struct CloudAppConfig
    {
        public string ProductUri;
        public string FileName;
        public string AppSID;
        public string AppKey;
    }
}
