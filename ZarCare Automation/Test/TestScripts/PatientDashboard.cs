namespace TestScripts
{
    public class PatientDashboard:Base
    {
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


    }
}
