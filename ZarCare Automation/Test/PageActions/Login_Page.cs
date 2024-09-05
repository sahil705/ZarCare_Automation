namespace ZarCare_Automation.Test.PageActions
{
    public class Login_Page:WebdriverSession
    {
        public static Login_Page_Locator LoginPage = new Login_Page_Locator();  

        public static void Validate_LoginPage() 
        {
            Generic_Utils.WindowHandle();
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(LoginPage.By_Login_Page_Text);

            Reports.childLog.Log(Status.Info, "Login page is displayed");
            Generic_Utils.GetScreenshot("Login page screenshot ");
        }

        public static void Navigate_To_RegisterPage ()
        {
            LoginPage.Web_Register_New_Account_Text.Click();
        }

        public static void Patient_Login(string email, string password)
        {
            LoginPage.Web_Email_TextBox.SendKeys(email);
            LoginPage.Web_Password_TextBox.SendKeys(password);  
            LoginPage.Web_SignIn_Button.Click();    
        }
    }
}
