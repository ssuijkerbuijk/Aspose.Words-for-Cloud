using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Cloud.AutoMerge
{
   public class AttachToEntity : CodeActivity
    {
        [RequiredArgument]
        [Input("Enable Logging")]
        [Default("False")]
        public InArgument<bool> EnableLogging { get; set; }

        [RequiredArgument]
        [Input("Attachment")]
        [ReferenceTarget("annotation")]
        public InArgument<EntityReference> AttachmentId { get; set; }

        [RequiredArgument]
        [Input("Entity Logical Name")]
        public InArgument<string> EntityName { get; set; }

        [RequiredArgument]
        [Input("Record ID")]
        public InArgument<string> RecordId { get; set; }


        protected override void Execute(CodeActivityContext executionContext)
        {
            Boolean Logging = EnableLogging.Get(executionContext);
            EntityReference Attachment = AttachmentId.Get(executionContext);
            string entityName = EntityName.Get(executionContext);
            string recordId = RecordId.Get(executionContext);
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            try
            {
                if (Logging)
                    Log("Workflow Execution Start", service);
                if (ValidateParameters(executionContext))
                {
                    if (Logging)
                        Log("Attaching Attachment", service);
                    Entity UpdatedAttachment = new Entity("annotation");
                    UpdatedAttachment.Id = Attachment.Id;
                    UpdatedAttachment.Attributes.Add("objectid", new EntityReference(entityName, new Guid(recordId)));
                    service.Update(UpdatedAttachment);
                    if (Logging)
                        Log("Attachment linked successfully", service);
                    if (Logging)
                        Log("Workflow Executed Successfully", service);
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, service);
            }
        }

        private bool ValidateParameters(CodeActivityContext executionContext)
        {
            return true;
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
