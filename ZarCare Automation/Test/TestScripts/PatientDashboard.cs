namespace TestScripts
{
    public class PatientDashboard:Base
    {
        public string classname = "PatientProfile";
        [Test]
        public void ValidatePatientDetailsInDashboard()
        {
            Reports.childLog = Reports.CreateNode("Validate the Submit Patient Detail in Patient Dashboard ");
            PatientDashboardValidations.ValidatePatientDetail();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void ValidateRedirectionOnPatientDashboardLinks()
        {
            Reports.childLog = Reports.CreateNode("Validate the Patient Profile Page Redirection Using Profile Pic Icon ");
            PatientDashboardValidations.ValidateRedirectionToPatientProfile();
            Reports.FlushNode(Reports.childLog);
        }
        
        [Test]
        public void ValidateDashboardActiveAppointmentCount()
        {
            Reports.childLog = Reports.CreateNode("Validate the Dashboard Active Appointment Count With Active Appointment Page ");
            PatientDashboardValidations.ValidateAppointmentCount();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void ValidateInvoiceDetails()
        {
            Reports.childLog = Reports.CreateNode("Validate the Invoice in Patient Dashboard for Last 3 Appointments Section ");
            PatientDashboardValidations.ValidateInvoiceFromDashboard();
            Reports.FlushNode(Reports.childLog);
        }
    }
}
