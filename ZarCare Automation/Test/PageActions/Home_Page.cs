namespace ZarCare_Automation.Test.PageActions
{
    public class Home_Page : WebdriverSession
    {
        public static Home_Page_Locators HomePage = new Home_Page_Locators();


        public static void Validate_HomePage()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(HomePage.By_BannerText);

            Reports.childLog.Log(Status.Info, "Home page is displayed");
            Generic_Utils.GetScreenshot("Home page screenshot");
        }

        public static void NavigateToConsultNow()
        {
            HomePage.Web_ConsultNow_Button.Click();
        }

        public static void NavigateToOurProvider()
        {
            HomePage.Web_OurProvider_Text.Click();  
            
        }

       public static void NavigateToLoginPage()
        {
            HomePage.Web_LoginSignUp_Button.Click();    
        }

        public static void NavigateToWorkWithUsPage()
        {
            HomePage.Web_WorkWithUs_Text.Click();
        }
    }
}
