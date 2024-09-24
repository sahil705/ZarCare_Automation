namespace ZarCare_Automation.Test.PageActions
{
    public class Patient_Profile_Page:WebdriverSession
    {
        public static Patient_Profile_Page_Locator PatientProfilePage = new Patient_Profile_Page_Locator();
        public static void ValidatePatientProfile()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(PatientProfilePage.By_Patient_Profile_Confirmation_Text);


            Reports.childLog.Log(Status.Info, "Patient Profile page is displayed");
            Generic_Utils.GetScreenshot("Patient Profile screenshot");
        }

        public static void NavigateToFindProviderPage()
        {
            PatientProfilePage.Web_Find_Provider_Link.Click();
        }

        public static void NavigateToActiveAppointment()
        {
            PatientProfilePage.Web_Active_Appointment_View_All_Link.Click();    
        }
    }
}
