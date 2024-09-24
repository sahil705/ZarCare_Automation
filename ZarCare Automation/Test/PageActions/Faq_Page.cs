namespace ZarCare_Automation.Test.PageActions
{
    public class Faq_Page : WebdriverSession
    {
        public static Faq_Locators Faq = new Faq_Locators();

        public static void Validate_Faq()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(Faq.By_Faq_Text);

            Reports.childLog.Log(Status.Info, "Faq page is displayed");
            Generic_Utils.GetScreenshot("Faq page screenshot");
        }

        public static void Get_and_Validate_Faq_Title(string Original_Title)
        {
            string Capture_Title = Generic_Utils.getTitle();
            Assert.That(Original_Title, Is.EqualTo(Capture_Title));
        }
    }
}
