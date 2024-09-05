namespace ZarCare_Automation.Test.PageElements
{
    public class Payment_Page_Locator:WebdriverSession
    {
        public By By_Payment_Page_Header = By.CssSelector("#payment-header-title");
        public IWebElement Web_Payment_Page_Header => driver.FindElement(By_Payment_Page_Header);

        public By By_Payment_Button = By.XPath("//div[@class='paywf-button'] //span[@class='wf-button button-label']");
        public IWebElement Web_Payment_Button =>driver.FindElement(By_Payment_Button);  
    }
}
