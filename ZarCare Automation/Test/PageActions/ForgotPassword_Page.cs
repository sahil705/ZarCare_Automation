namespace ZarCare_Automation.Test.PageActions
{
    public class ForgotPassword_Page:WebdriverSession
    {
        public static Forgot_Password_Locator ForgotPassword = new Forgot_Password_Locator();   

        public static void Validate_Forgot_Password_Page()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(ForgotPassword.By_Forgot_Password_Header);

            Reports.childLog.Log(Status.Info, "Forgot Password Page is displayed");
            Generic_Utils.GetScreenshot("Forgot Password Page Screenshot");
        }

        public static void NavigateToLogin()
        {
            ForgotPassword.Web_Back_To_Login.Click();
        }

    }
}
