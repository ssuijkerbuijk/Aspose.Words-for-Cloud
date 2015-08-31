using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Cloud.AutoMerge
{
    public class GenerateCopyOfDocument : CodeActivity
    {
        [RequiredArgument]
        [Input("Enable Logging")]
        [Default("False")]
        public InArgument<bool> EnableLogging { get; set; }

        [RequiredArgument]
        [Input("Attachment")]
        [ReferenceTarget("annotation")]
        public InArgument<EntityReference> AttachmentId { get; set; }

        [Output("Attachment")]
        [ReferenceTarget("annotation")]
        public OutArgument<EntityReference> OutputAttachmentId { get; set; }

        protected override void Execute(CodeActivityContext executionContext)
        {
            Boolean Logging = EnableLogging.Get(executionContext);
            EntityReference Attachment = AttachmentId.Get(executionContext);
            OutputAttachmentId.Set(executionContext, new EntityReference("annotation", Guid.Empty));
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            try
            {
                if (Logging)
                    Log("Workflow Execution Start", service);
                if (Logging)
                    Log("Reading Attachment", service);
                Entity ExistingAttachment = service.Retrieve(Attachment.LogicalName, Attachment.Id, new ColumnSet(true));
                if (ExistingAttachment != null)
                {
                    if (Logging)
                        Log("Creating New Attachment", service);
                    // Create new Attachment under Email Activity
                    Entity NewAttachment = new Entity("annotation");
                    if (ExistingAttachment.Contains("subject"))
                        NewAttachment.Attributes.Add("subject", ExistingAttachment["subject"]);
                    if (ExistingAttachment.Contains("filename"))
                        NewAttachment.Attributes.Add("filename", ExistingAttachment["filename"]);
                    if (ExistingAttachment.Contains("mimetype"))
                        NewAttachment.Attributes.Add("mimetype", ExistingAttachment["mimetype"]);
                    if (ExistingAttachment.Contains("documentbody"))
                        NewAttachment.Attributes.Add("documentbody", ExistingAttachment["documentbody"]);
                    Guid NewAttachmentId = service.Create(NewAttachment);
                    OutputAttachmentId.Set(executionContext, new EntityReference("annotation", NewAttachmentId));
                    if (Logging)
                        Log("New Attachment Created", service);
                }
                else
                {
                    if (Logging)
                        Log("Provided Attachment doesnot exist", service);
                }
                if (Logging)
                    Log("Workflow Executed Successfully", service);
            }
            catch (Exception ex)
            {
                Log(ex.Message, service);
            }
        }
        private void Log(string Message, IOrganizationService service)
        {
            //Entity LogEntry = new Entity("Aspose_AsposeLog");
            //LogEntry.Attributes.Add("Name", "Aspose.CLoud.AutoMerge.SendEmail");
            //LogEntry.Attributes.Add("Description", Message);
            //service.Create(LogEntry);
        }
    }
}
