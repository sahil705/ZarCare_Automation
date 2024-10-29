namespace ZarCare_Automation.Test.PageActions
{
    public class Home_Page : WebdriverSession
    {
        public static Home_Page_Locators HomePage = new Home_Page_Locators();
        public static ContactUs_Locators ContactUs = new ContactUs_Locators();
        

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

        public static void NavigateToContactUs()
        {
            Generic_Utils.ScrollToBottom();
            HomePage.Web_Contact_us_link.Click();

        }

        public static void EnterNewslatterEmail(string NewsLatterEmail)
        {
            Generic_Utils.ScrollToElement(HomePage.Web_NewLatterEmailEle);
            HomePage.Web_NewLatterEmailEle.SendKeys(NewsLatterEmail);
            HomePage.Web_NewsLatterSubBtnEle.Click();
       
        }
        public static void Validate_NewLatterEmailMessage(string ActualMessage)
        {
            Wait.GenericWait(2000);
            string ExpectedMessage = Generic_Utils.getText(HomePage.Web_newsEmailSucMessageEle);
            Assert.That(ExpectedMessage, Is.EqualTo(ActualMessage));
            Reports.childLog.Log(Status.Info, "success message displayed");
            Generic_Utils.GetScreenshot("Success Message screenshot");

        }
       

        public static void NavigateToOurProvider()
        {
            HomePage.Web_OurProvider_Text.Click();

        }

        public static void NavigateToLoginPage()
        {
            HomePage.Web_LoginSignUp_Button.Click();
            var Windows = driver.WindowHandles;

            driver.SwitchTo().Window(Windows[1]);
            Wait.WaitTillPageLoad();
        }

       
        public static void NavigateToAboutUs()
        {
            HomePage.Web_AboutUs_Link.Click();
        }

        public static void NavigateToFaq()
        {
             HomePage.Web_Faq_Link.Click();
        }

        public static void ClickToSpecialtyCard()
        {
             HomePage.Web_Speciality_Card.Click();
        }

        public static void NavigateToConnectNowPopup()
        {
            Wait.ElementIsVisible(HomePage.By_ConnectNow_Popup, 10); 
            Generic_Utils.IsElementDisplayed(HomePage.By_ConnectNow_Popup);
            HomePage.Web_ConnectNow_Popoup.Click();
        }

        public static void NavigateToConnectNowPopupClose()
        {              
              Generic_Utils.IsElementDisplayed(HomePage.By_ConnectNow_Popup);
              HomePage.Web_ConnectNow_Popup_Close.Click();
        }
       
        public static void NavigateToVideoConsultPage()
        {
            HomePage.Video_Consult_Link.Click();
        }

        public static void ValidateNewsletterSection()
        {
            
            Generic_Utils.ScrollToBottom(); 
            Generic_Utils.IsElementDisplayed(HomePage.By_SubscribeToNewsletter_h2);

            Reports.childLog.Log(Status.Info, "Newsletter Section is displayed");
            Generic_Utils.GetScreenshot("Newsletter Section screenshot");
        }
        public static void Enter_InvalidEmail_To_Subscribe_Textbox(string invalidEmail)
        {
            HomePage.Web_EmailInputBox.SendKeys(invalidEmail);

            Reports.childLog.Log(Status.Info, "Entering the Invalid Email Id");
            Generic_Utils.GetScreenshot("Invalid Email screenshot");
        }

        public static void ClickSubscribeButton()
        {
            HomePage.Web_EmailSubscribeButton.Click();
        }

        public static void GetAndValidateNewsletterErrorMessage(string OrigialErrorMessage)
        {
            string errorMessage = Generic_Utils.getText(HomePage.Web_InvalidEmailErrorMessage);
            Assert.That(OrigialErrorMessage, Is.EqualTo(errorMessage));

            Reports.childLog.Log(Status.Info, "Validating the error message");
            Generic_Utils.GetScreenshot("Error message screenshot");
        }

        
        public static void NavigateToBlogPage()
        {
            HomePage.Web_BlogPage_Link.Click();
        }

        public static void NavigateToWorkWithUsPage()
        {
            HomePage.Web_WorkWithUs.Click();
        }

      
    }
}