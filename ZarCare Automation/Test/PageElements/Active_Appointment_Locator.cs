namespace ZarCare_Automation.Test.PageElements
{
    public class Active_Appointment_Locator : WebdriverSession
    {
        public By By_Book_Appointment_Button = By.XPath("//div[@class='col-md-5 text-md-right text-left mb-3']/a");
        public IWebElement Web_Book_Appointment_Button => driver.FindElement(By_Book_Appointment_Button);

        public By By_ViewDetail_Button = By.XPath(".//a[@class='apt-btn book-appointment']");
        public IWebElement Web_ViewDetail_Button => driver.FindElement(By_ViewDetail_Button);

        public By By_Active_Appointment_Count = By.CssSelector("div.appointment-list h4");
        public IList<IWebElement> Web_Active_Appointment_Count => driver.FindElements(By_Active_Appointment_Count);

        public By By_Get_Appointment_Count = By.XPath("//div[@class='card-body']");

        public By By_AppointmentReferenceCode = By.XPath(".//h5[@class='doc-department' and contains(text(), '#')]");
        public IWebElement Web_AppointmentReferenceCode => driver.FindElement(By_AppointmentReferenceCode);

        public By By_Incomplete_MedicalFile_Popup_Header = By.XPath("//div[@id='medicalFileCompletion']//h4[@id='myModalLabel']");

        public By By_Incomplete_MedicalFile_Popup_Text = By.CssSelector("div[id='medicalFileCompletion'] div[class='modal-body'] span");
        public IWebElement Web_Incomplete_MedicalFile_Popup_Text => driver.FindElement(By_Incomplete_MedicalFile_Popup_Text);



    }
}
