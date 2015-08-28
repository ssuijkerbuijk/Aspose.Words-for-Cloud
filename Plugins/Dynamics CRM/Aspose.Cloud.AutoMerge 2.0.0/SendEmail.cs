using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

namespace Aspose.Cloud.AutoMerge
{
    public class SendEmail : CodeActivity
    {
        [Input("Enable Logging")]
        [Default("False")]
        public InArgument<bool> EnableLogging { get; set; }

        [Input("Email")]
        [ReferenceTarget("email")]
        public InArgument<EntityReference> EmailId { get; set; }

        protected override void Execute(CodeActivityContext executionContext)
        {
            Boolean Logging = EnableLogging.Get(executionContext);
            EntityReference Email = EmailId.Get(executionContext);
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            try
            {
                if (Logging)
                    Log("Workflow Execution Start",service);
                if (Logging)
                    Log("Sending Email", service);
                SendEmailRequest sendEmailreq = new SendEmailRequest();
                sendEmailreq.EmailId = Email.Id;
                sendEmailreq.TrackingToken = "";
                sendEmailreq.IssueSend = true;
                SendEmailResponse sendEmailresp = (SendEmailResponse)service.Execute(sendEmailreq);
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
            //LogEntry.Attributes.Add("Name", "Aspose.CLoud.AutoMerge.SendEmail");
            //LogEntry.Attributes.Add("Description", Message);
            //service.Create(LogEntry);
        }
    }
}
