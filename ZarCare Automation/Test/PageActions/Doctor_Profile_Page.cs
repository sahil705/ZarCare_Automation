namespace ZarCare_Automation.Test.PageActions
{
    public class Doctor_Profile_Page : WebdriverSession
    {
        public static Doctor_Profile_Page_Locators DoctorProfilePage = new Doctor_Profile_Page_Locators();

        public static void ValidateDoctorProfile()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(DoctorProfilePage.By_ProfileHeader);

            Reports.childLog.Log(Status.Info, "Doctor Profile page is displayed");
            Generic_Utils.GetScreenshot("Doctor Profile screenshot");
        }

        public static void BookAppointment(string appointmentDate, string appointmentTime)
        {
            //Select Appointment Date

            string Appointment_Currentdate = DoctorProfilePage.Web_BookingDateHeader_CurrentDate.Text;

            if (!Appointment_Currentdate.Equals(appointmentDate))
            {
                DoctorProfilePage.Web_BookingDate_ForwardButton.Click();
                Wait.GenericWait(1000);

                string Appointment_Nextdate = DoctorProfilePage.Web_BookingDateHeader_NextDate.Text;

                while (!Appointment_Nextdate.Equals(appointmentDate))
                {
                    DoctorProfilePage.Web_BookingDate_ForwardButton.Click();
                    Wait.GenericWait(1000);
                    Appointment_Nextdate = DoctorProfilePage.Web_BookingDateHeader_NextDate.Text;
                }
            }

            //Select Appointment Timeslot

            int slot_count = driver.FindElements(DoctorProfilePage.By_BookingSlot_Currentday).Count;

            for (int a = 0; a < slot_count; a++)
            {
                string slot_time = driver.FindElements(DoctorProfilePage.By_BookingSlot_Currentday)[a].Text;

                if(slot_time.Equals(appointmentTime))
                {
                    driver.FindElements(DoctorProfilePage.By_BookingSlot_Currentday)[a].Click();
                    break;
                }
            }
            Reports.childLog.Log(Status.Info, "Appointment Date and Time displayed");
            Generic_Utils.GetScreenshot("Appointment Date and Time Selected");

        }

        public static void Verify_Slot_Availability_On_Doctor_Profile(string appointmentDate, string appointmentTime)
        {
            //Select Appointment Date

            string Appointment_Currentdate = DoctorProfilePage.Web_BookingDateHeader_CurrentDate.Text;

            if (!Appointment_Currentdate.Equals(appointmentDate))
            {
                DoctorProfilePage.Web_BookingDate_ForwardButton.Click();
                Wait.GenericWait(1000);

                string Appointment_Nextdate = DoctorProfilePage.Web_BookingDateHeader_NextDate.Text;

                while (!Appointment_Nextdate.Equals(appointmentDate))
                {
                    DoctorProfilePage.Web_BookingDate_ForwardButton.Click();
                    Wait.GenericWait(1000);
                    Appointment_Nextdate = DoctorProfilePage.Web_BookingDateHeader_NextDate.Text;
                }
            }

            //Select Appointment Timeslot

            int slot_count = driver.FindElements(DoctorProfilePage.By_BookingSlot_Currentday).Count;

            for (int a = 0; a < slot_count; a++)
            {
                string slot_time = driver.FindElements(DoctorProfilePage.By_BookingSlot_Currentday)[a].Text;

                if (slot_time.Equals(appointmentTime))
                {
                    Console.WriteLine("Slot is present in Doctor Profile page");
                    break;
                }
            }

            Generic_Utils.GetScreenshot("Slot is visible on the Doctor Profile page ");

        }
        public static void ValidateEditSlotTimePage()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(DoctorProfilePage.By_EditSlotPage_cancelPolicyText);
            Console.WriteLine("Edit slot page validated");

            Reports.childLog.Log(Status.Info, "Edit slot time page is displayed");
            Generic_Utils.GetScreenshot("Edit slot time page screenshot");
        }
        public static void ValidateNewSlotSelectionAndPaymentPage(string NewSlotTime, string Symtoms)
        {
            DoctorProfilePage.Web_EditSlotTimeBtn.Click();
            Wait.WaitTillPageLoad();

            int TotalSlotAvaialble= DoctorProfilePage.Web_EditSlotPageAvailableSlot.Count;

            Console.WriteLine("Total slot are = "+ TotalSlotAvaialble);

            for (int a = 0; a < TotalSlotAvaialble; a++)
            {
                string NewSlotToselect = (DoctorProfilePage.Web_EditSlotPageAvailableSlot)[a].Text;

                if (NewSlotToselect.Equals(NewSlotTime))
                {
                    IWebElement NewSlotSelected = (DoctorProfilePage.Web_EditSlotPageAvailableSlot)[a];
                    NewSlotSelected.Click();
                    Wait.WaitTillPageLoad();
                    DoctorProfilePage.Web_EditSlotPageSubmitBtn.Click();
                    Wait.WaitTillPageLoad();
                    Console.WriteLine("Clicked on new slot and submit");
                    break;
                }
            }
             DoctorProfilePage.Web_SymtomsDropDownArrow.Click();
             Wait.WaitTillPageLoad();

            int SymtomsCount= DoctorProfilePage.Web_SymtomsList.Count();
            Console.WriteLine("sytoms count =" + SymtomsCount);

            for (int c = 0; c < SymtomsCount; c++)
            {
                string SymtomsToSelect = DoctorProfilePage.Web_SymtomsList[c].Text;

                if (SymtomsToSelect.Contains(Symtoms))
                {
                    DoctorProfilePage.Web_SymtomsCheckBoxes[c].Click();
                    Wait.WaitTillPageLoad();
                    Console.WriteLine("Required Symtoms selected");
                    break;
                }
            }
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.body.click();");
           
            DoctorProfilePage.Web_GotoPayBtn.Click();        
            Wait.WaitTillPageLoad();

        }
        public static void ValidateSelectedSlotPage()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(DoctorProfilePage.By_EditSlotTimeButton);

            Console.WriteLine("Validated selected slot page");

            Reports.childLog.Log(Status.Info, "Selected slot page is displayed");
            Generic_Utils.GetScreenshot("selected Slot page screenshot");

        }

        public static void ValidateSelectSymtomsAndNavigateToPaymentPage(string Symtoms)
        {
            DoctorProfilePage.Web_SymtomsDropDownArrow.Click();
            Wait.WaitTillPageLoad();

            int SymtomsCount = DoctorProfilePage.Web_SymtomsList.Count();
            Console.WriteLine("sytoms count =" + SymtomsCount);

            for (int c = 0; c < SymtomsCount; c++)
            {
                string SymtomsToSelect = DoctorProfilePage.Web_SymtomsList[c].Text;

                if (SymtomsToSelect.Contains(Symtoms))
                {
                    DoctorProfilePage.Web_SymtomsCheckBoxes[c].Click();
                    
                    Console.WriteLine("Required Symtoms selected");
                    break;
                }
            }
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.body.click();");

            Wait.WaitTillPageLoad();
            Reports.childLog.Log(Status.Info, "Appointment Slot and symtoms selected");
            Generic_Utils.GetScreenshot("Appointment Slot and symtoms selected screenshot");

            DoctorProfilePage.Web_GotoPayBtn.Click();
            Wait.WaitTillPageLoad();
            

        }
        public static void ValidatePaymentCancelSuccessMessageandSlotAvailable(string PaymentCancelMessage, string AppointmentTime)
        {
            string PaymentCancelActualMessage=DoctorProfilePage.Web_CancelPaymentMessage.Text;

            Assert.That(PaymentCancelActualMessage, Is.EqualTo(PaymentCancelMessage));

            
            string AvailableSlotText = DoctorProfilePage.Web_SelectedSlotTime.Text;

            StringAssert.Contains(AppointmentTime, AvailableSlotText, "The slot text does not contain the specified appointmrnt time.");

            Reports.childLog.Log(Status.Info, "Paymnet cancelled message and Slot available");
            Generic_Utils.GetScreenshot("Paymnet cancelled message and Slot available screenshot");
        }
    }
}
