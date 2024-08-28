namespace ZarCare_Automation.Test.PageElements
{
    public class Home_Page_Locators : WebdriverSession
    {
        public By By_BannerText = By.XPath("//article[@class='hero-banner-txt']/h1/span");
        public IWebElement Web_BannerText => driver.FindElement(By_BannerText);

        public By By_ConsultNow_Button = By.XPath("//article[@class='hero-banner-txt']/a");
        public IWebElement Web_ConsultNow_Button => driver.FindElement(By_ConsultNow_Button);

        public By By_OurProvider_Text = By.XPath("(//ul[@class='top-menu']//a)[1]");
        public IWebElement Web_OurProvider_Text => driver.FindElement(By_OurProvider_Text);

        public By By_LoginSignUp_Button = By.XPath("(//a[@class='btn-loginsignup'])[1]");
        public IWebElement Web_LoginSignUp_Button => driver.FindElement(By_LoginSignUp_Button);

        public By By_WorkWithUs_Text = By.XPath("(//ul[@class='top-menu']/li)[3]");
        public IWebElement Web_WorkWithUs_Text => driver.FindElement(By_WorkWithUs_Text);
    }
}
