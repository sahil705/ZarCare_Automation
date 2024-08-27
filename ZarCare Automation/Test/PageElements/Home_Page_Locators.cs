namespace ZarCare_Automation.Test.PageElements
{
    public class Home_Page_Locators : WebdriverSession
    {
        public By By_BannerText = By.XPath("//article[@class='hero-banner-txt']/h1/span");
        public IWebElement Web_BannerText => driver.FindElement(By_BannerText);

        public By By_ConsultNow_Button = By.XPath("//article[@class='hero-banner-txt']/a");
        public IWebElement Web_ConsultNow_Button => driver.FindElement(By_ConsultNow_Button);

        public By Work_with_us_Button = By.XPath("(//ul[@class='top-menu']/li)[3]");
        public IWebElement Web_Work_with_Us_Btn => driver.FindElement(Work_with_us_Button);

        public By by_Contact_us_element = By.XPath("//footer//a[text()='Contact Us']");

        public IWebElement Web_Contact_us_link => driver.FindElement(by_Contact_us_element);

        public By By_loginButtonElement = By.XPath("//div[@class='header-menu-parent']//a[@class='btn-loginsignup']");

        public IWebElement Web_login_Btn => driver.FindElement(By_loginButtonElement);

        public By By_NewsLatterEmailField = By.XPath("//input[@id='emailNewsLetter']");

        public IWebElement Web_NewLatterEmailEle => driver.FindElement(By_NewsLatterEmailField);

        public By by_NewsEmailSuccessMessage = By.XPath("//div[@class='alert-successnewsletter']");

        public IWebElement Web_newsEmailSucMessageEle=> driver.FindElement(by_NewsEmailSuccessMessage);

        public By by_NewLatterSubsBtn = By.XPath("//button[@class='newsletter-button']");

        public IWebElement Web_NewsLatterSubBtnEle => driver.FindElement(by_NewLatterSubsBtn);

        public By by_OurProvidebtn = By.XPath("//ul[@class='top-menu']//li//a[contains(text(),'Our Providers' )]");

        public IWebElement Web_Our_providerBtn=> driver.FindElement(by_OurProvidebtn);






    }
}
