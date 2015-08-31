using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

namespace Aspose.Cloud.AutoMerge
{
    public class AttachToEmail : CodeActivity
    {
        [Input("Enable Logging")]
        [Default("False")]
        public InArgument<bool> EnableLogging { get; set; }

        [Input("Email")]
        [ReferenceTarget("email")]
        public InArgument<EntityReference> EmailId { get; set; }

        [Input("Attachment")]
        [ReferenceTarget("annotation")]
        public InArgument<EntityReference> AttachmentId { get; set; }

        protected override void Execute(CodeActivityContext executionContext)
        {
            Boolean Logging = EnableLogging.Get(executionContext);
            EntityReference Email = EmailId.Get(executionContext);
            EntityReference Attachment = AttachmentId.Get(executionContext);
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            try
            {
                if (Logging)
                    Log("Workflow Execution Start", service);
                if (Logging)
                    Log("Retrieving Attahment", service);
                Entity TempAttachment = service.Retrieve("annotation", Attachment.Id, new ColumnSet(true));
                if (TempAttachment != null)
                {
                    if (Logging)
                        Log("Creating New Attachment", service);
                    Entity NewAttachment = new Entity("activitymimeattachment");
                    if (TempAttachment.Contains("subject"))
                        NewAttachment.Attributes.Add("subject", TempAttachment["subject"]);
                    if (TempAttachment.Contains("filename"))
                        NewAttachment.Attributes.Add("filename", TempAttachment["filename"]);
                    if (TempAttachment.Contains("mimetype"))
                        NewAttachment.Attributes.Add("mimetype", TempAttachment["mimetype"]);
                    if (TempAttachment.Contains("documentbody"))
                        NewAttachment.Attributes.Add("body", TempAttachment["documentbody"]);
                    NewAttachment.Attributes.Add("objectid", new EntityReference(Email.LogicalName, Email.Id));
                    NewAttachment.Attributes.Add("objecttypecode", "email");
                    NewAttachment.Attributes.Add("attachmentnumber", 1);
                    service.Create(NewAttachment);
                    if (Logging)
                        Log("New Attachment Added To Email", service);
                }
                else
                {
                    if (Logging)
                        Log("Temp Attachment doesnot exist", service);
                }
                if (Logging)
                    Log("Workflow Executed Successfully", service);
            }
            catch (Exception ex)
            {
                Log(ex.Message, service);
                throw ex;
            }
        }

        private void Log(string Message, IOrganizationService service)
        {
            //Entity LogEntry = new Entity("Aspose_AsposeLog");
            //LogEntry.Attributes.Add("Name", "Aspose.CLoud.AutoMerge.AttachToEmail");
            //LogEntry.Attributes.Add("Description", Message);
            //service.Create(LogEntry);
        }
    }
}
