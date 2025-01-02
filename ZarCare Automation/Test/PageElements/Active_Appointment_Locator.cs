namespace ZarCare_Automation.Test.PageElements
{
    public class Active_Appointment_Locator : WebdriverSession
    {
        public By By_Book_Appointment_Button = By.XPath("//div[@class='col-md-5 text-md-right text-left mb-3']/a");
        public IWebElement Web_Book_Appointment_Button => driver.FindElement(By_Book_Appointment_Button);

        public By By_ViewDetail_Button = By.XPath("//div[@class='clinic-booking'] //a[@class='apt-btn book-appointment']");
        public IWebElement Web_ViewDetail_Button => driver.FindElement(By_ViewDetail_Button);

        public By By_Active_Appointment_Count = By.CssSelector("div.appointment-list h4");
        public IList<IWebElement> Web_Active_Appointment_Count => driver.FindElements(By_Active_Appointment_Count);
    }
}
