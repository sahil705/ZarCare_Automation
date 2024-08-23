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

        public By By_Faq_Link = By.LinkText("FAQ");
        public IWebElement Web_Faq_Link => driver.FindElement(By_Faq_Link);

        public By By_WorkWithUs_Link = By.XPath("(//ul[@class='top-menu']/li)[3]");
        public IWebElement Web_WorkWithUs_Link => driver.FindElement(By_WorkWithUs_Link);

        public By By_Specialty_List = By.XPath("//div[@class='owl-item active']/div");
        public IWebElement Web_Specialty_List => driver.FindElement(By_Specialty_List);

        public By By_Speciality_Card = By.XPath("//div[@class='owl-item active']/div //div[@class='horizontal-list-card']/a");
        public IWebElement Web_Speciality_Card => driver.FindElement(By_Speciality_Card);

        public By By_OurProviders_Link = By.LinkText("OUR PROVIDERS");
        public IWebElement Web_OurProviders_Link => driver.FindElement(By_OurProviders_Link);

        public By By_ConnectNow_Popup = By.XPath("//a[@id='connect-pop-link']");
        public IWebElement Web_ConnectNow_Popoup => driver.FindElement(By_ConnectNow_Popup);

        public By By_ConnctNow_Popup_Close = By.XPath("//div[@class='modal-connect-image']//button[@class='connect-pop-close']/i");
        public IWebElement Web_ConnectNow_Popup_Close => driver.FindElement(By_ConnctNow_Popup_Close);

    }
   
}
