namespace TestScripts 
{
    
    public class Login:Base
    {
        [Test]
        public void Login_Page_Redirection()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Validate the homepage");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToLoginPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 1: Open Login Page and Validate the homepage");
            Login_Page.Validate_LoginPage();    
            Reports.FlushNode(Reports.childLog);
        }
    }
}
