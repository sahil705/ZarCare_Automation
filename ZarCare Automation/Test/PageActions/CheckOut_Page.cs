namespace ZarCare_Automation.Test.PageActions
{
    public class CheckOut_Page:WebdriverSession
    {
        public static CheckOut_Page_Locator CheckoutPage = new CheckOut_Page_Locator();

        public static void Validate_CheckOut()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(CheckoutPage.By_CheckOut_Page_Header);


            Reports.childLog.Log(Status.Info, "Checkout page is displayed");
            Generic_Utils.GetScreenshot("Checkout screenshot");
        }

        public static void Voucher_Apply_And_Get_Success_Message(string voucherCode, string originalText)
        {
            CheckoutPage.Web_Voucher_TextBox.SendKeys(voucherCode); 
            CheckoutPage.Web_Voucher_Consent_Checkbox.Click();
            IWebElement Apply_Button = Wait.ElementIsClickable(CheckoutPage.Web_Voucher_Apply_Button, 5);
            Apply_Button.Click();
            IWebElement Capture_Success_Element = Wait.ElementIsVisible(CheckoutPage.By_Voucher_Success_Message, 5);
            string Capture_Success_Message_Text = Generic_Utils.getText(Capture_Success_Element);
            Assert.That(originalText, Is.EqualTo(Capture_Success_Message_Text));
        }

        public static void Add_Symptom_And_Click_On_Continue_Button()
        {
            Generic_Utils.ScrollToBottom();
            Wait.GenericWait(2000);
            CheckoutPage.Web_Symptoms_Dropdown.Click();
            IWebElement Dropdown = CheckoutPage.Web_Symptoms_Dropdown;
            Generic_Utils.ScrollToElement(Dropdown);
            Dropdown.Click();
            CheckoutPage.Web_Symptoms_Name.Click(); 
            Dropdown.Click();
            CheckoutPage.Web_Continue_Payment_Button.Click();
        }
        public static void Public_Booking_Continue_Button()
        {
            Generic_Utils.ScrollToBottom();
            Wait.GenericWait(2000);
           
            IWebElement Dropdown = CheckoutPage.Web_Symptoms_Dropdown;
            Generic_Utils.ScrollToElement(Dropdown);
            Dropdown.Click();
            CheckoutPage.Web_Public_Checkout_Symptoms_Name.Click();
            Dropdown.Click();
            CheckoutPage.Web_Continue_Payment_Button.Click();
        }
    }
}
