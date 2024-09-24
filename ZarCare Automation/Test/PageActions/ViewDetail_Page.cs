namespace ZarCare_Automation.Test.PageActions
{
    public class ViewDetail_Page:WebdriverSession
    {
        public static ViewDetail_Page_Locator ViewDetail = new ViewDetail_Page_Locator();

        public static void Validate_ViewDetailPage()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(ViewDetail.By_View_Detail_Page_Element);

            Reports.childLog.Log(Status.Info, "View Detail page is displayed");
            Generic_Utils.GetScreenshot("View Detail page screenshot");
        }

        public static void CancelAppointment()
        {
            ViewDetail.Web_Cancel_Appointment_Button.Click();
            Wait.ElementIsVisible(ViewDetail.By_Payment_Method_Popup, 10);
            ViewDetail.Web_Refund_Checkbox.Click(); 
            ViewDetail.Web_Confirmation_Popup_Yes_Button.Click();
            IWebElement CancellationConfirmation = Wait.ElementIsClickable(ViewDetail.Web_Confirmation_Popup_Ok_Button, 10);
            CancellationConfirmation.Click();
            driver.Navigate().GoToUrl("https://zarcare-preprod.azurewebsites.net/our-health-practitioners");
            Wait.WaitTillPageLoad();
        }
    }
}
