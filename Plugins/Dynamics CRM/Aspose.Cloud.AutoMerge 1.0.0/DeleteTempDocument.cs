using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

namespace Aspose.Cloud.AutoMerge
{
    public class DeleteTempDocument : CodeActivity
    {
        [Input("Enable Logging")]
        [Default("False")]
        public InArgument<bool> EnableLogging { get; set; }

        [Input("Attachment")]
        [ReferenceTarget("annotation")]
        public InArgument<EntityReference> AttachmentId { get; set; }

        protected override void Execute(CodeActivityContext executionContext)
        {
            Boolean Logging = EnableLogging.Get(executionContext);
            EntityReference Attachment = AttachmentId.Get(executionContext);
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            try
            {
                if (Logging)
                    Log("Workflow Execution Start", service);
                if (Logging)
                    Log("Removing Attachment", service);
                service.Delete(Attachment.LogicalName, Attachment.Id);
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
            //LogEntry.Attributes.Add("Name", "Aspose.CLoud.AutoMerge.DeleteTempDocument");
            //LogEntry.Attributes.Add("Description", Message);
            //service.Create(LogEntry);
        }
    }
}
