namespace ZarCare_Automation.Test.PageElements
{
    public class ViewDetail_Page_Locator:WebdriverSession
    {
        public By By_View_Detail_Page_Element = By.XPath("card-title mb-3 mb-md-0");
        public IWebElement Web_View_Detail_Page_Element =>  driver.FindElement(By_View_Detail_Page_Element);

        public By By_Cancel_Appointment_Button = By.Id("btnCancelAppt");
        public IWebElement Web_Cancel_Appointment_Button => driver.FindElement(By_Cancel_Appointment_Button);

        public By By_Payment_Method_Popup = By.XPath("//div[@class='modal-body popup-text']");
        public IWebElement Web_Payment_Method_Popup => driver.FindElement(By_Payment_Method_Popup);

        public By By_Refund_Checkbox = By.Name("refundOptions");
        public IWebElement Web_Refund_Checkbox => driver.FindElement(By_Refund_Checkbox);

        public By By_Confirmation_Popup_Yes_Button = By.Id("btnYes");
        public IWebElement Web_Confirmation_Popup_Yes_Button => driver.FindElement(By_Confirmation_Popup_Yes_Button);

        public By By_Confirmation_Popup_Ok_Button = By.Id("btnGenericStatusOk");
        public IWebElement Web_Confirmation_Popup_Ok_Button => driver.FindElement(By_Confirmation_Popup_Ok_Button);

    }
}
