namespace ZarCare_Automation.Test.PageElements
{
    public class Payment_Confirmation_Page_Locator:WebdriverSession
    {
        public By By_Confirmation_Page_Element = By.XPath("//div[@class='text-center px-3']/img");
        public IWebElement Web_Confirmation_Page_Element =>driver.FindElement(By_Confirmation_Text);

        public By By_Confirmation_Text = By.XPath("//div[@class='success_text_book']/h3");
        public IWebElement Web_Confirmation_Text =>driver.FindElement(By_Confirmation_Text);    
        

    }
}
