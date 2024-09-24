using System;

namespace ZarCare_Automation.Test.PageActions
{
    public class ActiveAppointment_Page:WebdriverSession
    {
        public static Active_Appointment_Locator ActiveAppointment = new Active_Appointment_Locator();
        public static void Validate_Active_Appointment_Page()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(ActiveAppointment.By_Book_Appointment_Button);

            Reports.childLog.Log(Status.Info, "Active Appointment page is displayed");
            Generic_Utils.GetScreenshot("Active Appointment page screenshot");
        }

        public static void NavigateToViewDetailPage()
        {
            ActiveAppointment.Web_ViewDetail_Button.Click();    
        }

    }
}
