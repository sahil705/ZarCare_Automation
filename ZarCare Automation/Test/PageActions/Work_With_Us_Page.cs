namespace ZarCare_Automation.Test.PageActions
{
    public class Work_With_Us_Page : WebdriverSession
    {
        public static Work_With_Us_Locators Work_With_Us = new Work_With_Us_Locators();

        public static void Validate_WorkWithUs()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(Work_With_Us.By_Work_With_Us_Text);

            Reports.childLog.Log(Status.Info, "WorkWithUs Page is displayed");
            Generic_Utils.GetScreenshot("WorkWithUs page screenshot");
        }

        public static void Get_and_Validate_WorkWithUs_Text(string Original_Title)
        {
            string Capture_Title = Generic_Utils.getTitle();
            Assert.That(Original_Title, Is.EqualTo(Capture_Title));
        }


        public static void NavigateToSubmitButton()
        {
            Work_With_Us.Web_Submit_Button.Click();
        }
    }
}
