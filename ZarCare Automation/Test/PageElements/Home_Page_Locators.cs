namespace ZarCare_Automation.Test.PageElements
{
    public class Home_Page_Locators : WebdriverSession
    {
        public By By_BannerText = By.XPath("//article[@class='hero-banner-txt']/h1/span");
        public IWebElement Web_BannerText => driver.FindElement(By_BannerText);

        public By By_ConsultNow_Button = By.XPath("//article[@class='hero-banner-txt']/a");
        public IWebElement Web_ConsultNow_Button => driver.FindElement(By_ConsultNow_Button);

        public By By_AboutUs_Link = By.LinkText("About Us");
        public IWebElement Web_AboutUs_Link => driver.FindElement(By_AboutUs_Link);

        //VideoConsultPage Locators

        public By video_consult_link = By.XPath("//ul[@class='top-menu']/li[2]");
        public IWebElement Video_Consult_Link => driver.FindElement(video_consult_link);

        // SubscribeToNewsLetter Test Case Locators

        public By By_SubscribeToNewsletter_h2 = By.XPath("//article[@class='newsletter-hld-inn']/h2");
        public IWebElement Web_SubscribeToNewsletter_h2 => driver.FindElement(By_SubscribeToNewsletter_h2);

        public By By_EmailInputBox = By.XPath("//div[@class='newsletter-form']/input");
        public IWebElement Web_EmailInputBox => driver.FindElement(By_EmailInputBox);

        public By By_EmailSubscribeButton = By.XPath("//div[@class='newsletter-form']/button");
        public IWebElement Web_EmailSubscribeButton => driver.FindElement(By_EmailSubscribeButton);

        public By By_InvalidEmailErrorMessage = By.Id("errormsg-newsletteremail");
        public IWebElement Web_InvalidEmailErrorMessage => driver.FindElement(By_InvalidEmailErrorMessage);

        //BlogPageLocators:

        public By By_BlogPage_Link = By.XPath("//ul[@class='top-menu']/li[4]");
        public IWebElement Web_BlogPage_Link => driver.FindElement(By_BlogPage_Link);

        //Work With Us Locators

        public By By_WorkWithUs = By.XPath("//ul[@class='top-menu']//li[3] ");
        public IWebElement Web_WorkWithUs => driver.FindElement(By_WorkWithUs);

        //OurProvider Locators:

        public By By_OurProvidersPage = By.XPath("//ul[@class='top-menu']/li[1]");
        public IWebElement Web_OurProvidersPage => driver.FindElement(By_OurProvidersPage);
    }
}