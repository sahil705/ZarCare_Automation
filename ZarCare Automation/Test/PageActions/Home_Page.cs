using OpenQA.Selenium.DevTools.V124.Runtime;

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

        public static void NavigateToAboutUs()
        {
            HomePage.Web_AboutUs_Link.Click();
        }

        public static void NavigateToFaq()
        {
            HomePage.Web_Faq_Link.Click();
        }

        public static void NavigateToSpecialtyCard()
        {
            HomePage.Web_Speciality_Card.Click();
        }

        public static void NavigateToWorkWithUs()
        {
            HomePage.Web_WorkWithUs_Link.Click();
        }
    }
}
