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

        public static void ValidateMedicalFileStatusAndNavigateToViewDetail(string appointmentNumber, string patientName, string incompleteMedicalFileText)
        {
            bool status = MedicalFiles_Page.Get_Medical_File_Status(patientName);

            Patient_Dashboard_Page.NavigateToActiveAppointment();
            IList<IWebElement> appointmentRecords = driver.FindElements(ActiveAppointment.By_Get_Appointment_Count);

            foreach(IWebElement appointment in appointmentRecords)
            {
                IWebElement referenceCode = appointment.FindElement(ActiveAppointment.By_AppointmentReferenceCode);
                string referenceCodeText = referenceCode.Text;

                if (referenceCodeText.Equals(appointmentNumber))
                {
                    IWebElement viewDetailButton = appointment.FindElement(ActiveAppointment.By_ViewDetail_Button);
                    Wait.ElementIsClickable(viewDetailButton, 5).Click();

                    if(status == true)
                    {
                        ViewDetail_Page.Validate_ViewDetailPage();
                    }
                    else
                    {
                        Wait.ElementIsVisible(ActiveAppointment.By_Incomplete_MedicalFile_Popup_Header, 5);
                        string popupText = ActiveAppointment.Web_Incomplete_MedicalFile_Popup_Text.Text;
                        Assert.That(popupText, Is.EqualTo(incompleteMedicalFileText));  
                    
                    }
                    break;
                }

            }
        }

    }
}
