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

        public By By_AboutUs_Link = By.LinkText("About Us");        
        public IWebElement Web_AboutUs_Link => driver.FindElement(By_AboutUs_Link);
        public By By_OurProvider_Text = By.XPath("(//ul[@class='top-menu']//a)[1]");
        public IWebElement Web_OurProvider_Text => driver.FindElement(By_OurProvider_Text);

        public By By_LoginSignUp_Button = By.XPath("(//a[@class='btn-loginsignup'])[1]");
        public IWebElement Web_LoginSignUp_Button => driver.FindElement(By_LoginSignUp_Button);

        public By By_WorkWithUs_Text = By.XPath("(//ul[@class='top-menu']/li)[3]");
        public IWebElement Web_WorkWithUs_Text => driver.FindElement(By_WorkWithUs_Text);
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
