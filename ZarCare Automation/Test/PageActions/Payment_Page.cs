namespace ZarCare_Automation.Test.PageActions
{
    public class Payment_Page:WebdriverSession
    {
      public static Payment_Page_Locator PaymentPage = new Payment_Page_Locator();

        public static void Validate_Payment()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(PaymentPage.By_Payment_Page_Header);


            Reports.childLog.Log(Status.Info, "Payment page is displayed");
            Generic_Utils.GetScreenshot("Payment page screenshot");
        }

        public static void Click_On_Payment_Page()
        {
            PaymentPage.Web_Payment_Button.Click();
            Wait.GenericWait(20000);   
        }
    }
}
