using AngleSharp.Dom;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ZarCare_Automation.Test.PageActions
{
    public class Home_Page : WebdriverSession
    {
        public static Home_Page_Locators HomePage = new Home_Page_Locators();

        public static Work_with_Us_pageLocators WorkWith_us = new Work_with_Us_pageLocators();

        public static ContactUsPageLocatores ContactUs = new ContactUsPageLocatores();

        public static Our_Providers_Page_Locators OurProvPage= new Our_Providers_Page_Locators();

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

        public static void ValidateWork_with_us_Click()
        {
            HomePage.Web_Work_with_Us_Btn.Click();

            
        }

        public static void ConstactUsLinkClick()
        {
            Generic_Utils.ScrollToBottom();
               
             HomePage.Web_Contact_us_link.Click();
  
        }

        public static void LoginBtnClick()
        {
            HomePage.Web_login_Btn.Click();

            var Windows= driver.WindowHandles;

            driver.SwitchTo().Window(Windows[1]);
            
        }

        public static void EnterNewslatterEmail(string NewsLatterEmail) 
        {
            Generic_Utils.ScrollToElement(HomePage.Web_NewLatterEmailEle);

            HomePage.Web_NewLatterEmailEle.SendKeys(NewsLatterEmail);  

            HomePage.Web_NewsLatterSubBtnEle.Click();
            Thread.Sleep(1000);

        }
        public static void Validate_NewLatterEmailMessage(string ActualMessage)
        {
           

            string ExpectedMessage = driver.FindElement(HomePage.by_NewsEmailSuccessMessage).Text;

            Assert.AreEqual(ActualMessage, ExpectedMessage);
            Reports.childLog.Log(Status.Info, "success message displayed");
            Generic_Utils.GetScreenshot("Success Message screenshot");

        }
        public static void OurProviderBtnClick()
        {
            HomePage.Web_Our_providerBtn.Click();

            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(OurProvPage.By_SearchHeader);


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
