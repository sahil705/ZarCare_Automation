namespace TestScripts
{
    public class Login:Base
    {
        [Test]
        public void LoginFormSubmission()
        {
            Reports.childLog = Reports.CreateNode("Verify the Login Form Submission");
            LoginValidation.ValidateUserLoginWithValidData();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Validate the Login with Invalid Data");
            LoginValidation.ValidateUserLoginWithInvalidData();
            Reports.FlushNode(Reports.childLog);

        }

        [Test]
        public void NavigateToLoginLinks()
        {
            Reports.childLog = Reports.CreateNode(" Validate Login Page Links");
            LoginValidation.RedirectionLinksOnLoginPage();
            Reports.FlushNode(Reports.childLog);    
        }

        [Test]
        public void NavigateToUnverifiedPatientDashboard()
        {
            Reports.childLog = Reports.CreateNode(" Navigate the Patient Dashboard for Unverified Email and Cell");
            LoginValidation.ValidateUnverifiedEmailAndCell();
            Reports.FlushNode(Reports.childLog);
        }
    }
}
