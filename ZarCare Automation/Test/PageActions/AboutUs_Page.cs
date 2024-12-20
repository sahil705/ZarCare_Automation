namespace ZarCare_Automation.Test.PageActions
{
    public class AboutUs_Page : WebdriverSession
    {
        
        public static About_Us_Locators About_Us = new About_Us_Locators();

            public static void Validate_AboutUs()
            {
                Wait.WaitTillPageLoad();
                Generic_Utils.IsElementDisplayed(About_Us.By_AboutUs_Text);

                Reports.childLog.Log(Status.Info, "AboutUs Page is displayed");
                Generic_Utils.GetScreenshot("AboutUs page screenshot");
            }

            public static void Get_and_Validate_AboutUs_Title(string Original_Title)
            {
               
               string Capture_Title = Generic_Utils.getTitle();
               Assert.That(Original_Title, Is.EqualTo(Capture_Title));
               
               Reports.childLog.Log(Status.Info, "AboutUs Page is displayed");
               Generic_Utils.GetScreenshot("AboutUs page screenshot");
            }
        
    }
}

