
namespace ZarCare_Automation.Test.PageElements
{
    public class About_Us_Locators : WebdriverSession
    {
        public By By_AboutUs_Text = By.XPath("//div[@class='section-inner-header about-inner-header']/h6");
        public IWebElement Web_AboutUs_Text => driver.FindElement(By_AboutUs_Text);
    }
}
