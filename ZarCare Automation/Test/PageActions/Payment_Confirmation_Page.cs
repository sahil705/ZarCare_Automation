namespace ZarCare_Automation.Test.PageActions
{
    public class Payment_Confirmation_Page:WebdriverSession
    {
        public static Payment_Confirmation_Page_Locator PaymentConfirmationPage = new Payment_Confirmation_Page_Locator();

        public static void Validate_Payment_Confirmation()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(PaymentConfirmationPage.By_Confirmation_Page_Element);

            Reports.childLog.Log(Status.Info, "Payment confirmation page is displayed");
            Generic_Utils.GetScreenshot("Payment confirmation screenshot");
        }

        public static void Get_And_Validate_Confirmation_Page_Text(string confirmationText)
        {
            string Capture_Text = Generic_Utils.getText(PaymentConfirmationPage.Web_Confirmation_Text);
            Assert.That(confirmationText, Is.EqualTo(Capture_Text));
        }
    }
}
