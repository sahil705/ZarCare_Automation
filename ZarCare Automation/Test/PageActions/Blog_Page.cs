namespace ZarCare_Automation.Test.PageActions
{
    public class Blog_Page : WebdriverSession
    {
        public static Blog_Page_Locators BlogPage = new Blog_Page_Locators();

        public static void Validate_BlogPage()
        {
            Generic_Utils.WindowHandle();
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(BlogPage.By_ZarcareBlog);

            Reports.childLog.Log(Status.Info, "Blog Page is displayed");
            Generic_Utils.GetScreenshot("Blog Page screenshot");

        }

    }
}
