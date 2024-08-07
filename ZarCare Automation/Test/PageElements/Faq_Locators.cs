namespace ZarCare_Automation.Test.PageElements
{
    public class Faq_Locators : WebdriverSession
    {
        public By By_Faq_Text = By.XPath("//div[@class='col-md-12 mt-3 mb-4']/h1");
        public IWebElement Web_Faq_Text => driver.FindElement(By_Faq_Text);

    }
}
