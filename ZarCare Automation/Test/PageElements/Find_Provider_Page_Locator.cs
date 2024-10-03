namespace ZarCare_Automation.Test.PageElements
{
    public class Find_Provider_Page_Locator:WebdriverSession
    {
        public By By_Find_Provider_Page_Confirmation_Text = By.XPath("//div[@class='item-input-wrap col-md-2 col-lg-3']/button");
        public IWebElement Web_Find_Provider_Page_Confirmation_Text => driver.FindElement(By_Find_Provider_Page_Confirmation_Text);

        public By By_Category_Dropdown = By.XPath("//select[@class='form-control']");
        public IWebElement Web_Category_Dropdown => driver.FindElement(By_Category_Dropdown);

        public By By_Search_Button = By.XPath("//div[@class='item-input-wrap col-md-2 col-lg-3']/button");
        public IWebElement Web_Search_Button => driver.FindElement(By_Search_Button);

        public By By_Provider_List = By.XPath("//div[@class='card mb-4 card-new']");
        public IList <IWebElement> Web_Provider_List =>driver.FindElements(By_Provider_List);

        public By By_Provider_Name = By.XPath(".//h4[@class='doc-name']");
        public IWebElement Web_Provider_Name =>driver.FindElement(By_Provider_Name);

        public By By_Book_Appointment_Button = By.XPath(".//div[@class='doc-info-right-new'] //div[@class='clinic-booking-new']");
        public IWebElement Web_Book_Appointment_Button =>driver.FindElement (By_Book_Appointment_Button);

        public By By_Appointment_Date_Text = By.XPath("//div[@class='owl-item active']/div/h4");
        public IList <IWebElement> Web_Appointment_Date_Text => driver.FindElements(By_Appointment_Date_Text);

        public By By_Today_Date_Text = By.XPath("//div[@class='owl-item active current']/div/h4");
        public IWebElement Web_Today_Date_Text => driver.FindElement(By_Today_Date_Text);

        public By By_Get_Provider_Slot_List = By.XPath("//div[@class='owl-item active'] //div[@class='c-day-session-slot-blue']");
        public IList<IWebElement> Web_Get_Provider_Slot_List => driver.FindElements(By_Get_Provider_Slot_List);

    }
}
