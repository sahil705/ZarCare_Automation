namespace ZarCare_Automation.Test.PageActions
{
    public class Patient_Dashboard_Page : WebdriverSession
    {
        public static Patient_Dashboard_Page_Locator PatientDashboardPage = new Patient_Dashboard_Page_Locator();
        public static Active_Appointment_Locator ActiveAppointmentPage = new Active_Appointment_Locator();
        public static CheckOut_Page_Locator CheckoutPage = new CheckOut_Page_Locator();

        public static void ValidatePatientDashboard()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(PatientDashboardPage.By_Patient_Dashboard_Confirmation_Text);


            Reports.childLog.Log(Status.Info, "Patient Dashboard page is displayed");
            Generic_Utils.GetScreenshot("Patient Dashboard screenshot");
        }

        public static void ValidateUnverifiedDashboard()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(PatientDashboardPage.By_Unverified_Dashboard_Element);

            Reports.childLog.Log(Status.Info, "Unverified Patient Dashboard page is displayed");
            Generic_Utils.GetScreenshot("Unverified Patient Dashboard screenshot");

        }
        public static void NavigateToDashboard()
        {
            PatientDashboardPage.Web_Dashboard_Link.Click();
        }
        public static void HandleNotificationPopupOnDashboard()
        {
            try
            {
                Wait.ElementIsVisible(PatientDashboardPage.By_Notification_Popup, 5);

                IWebElement laterButton = Wait.ElementIsClickable(PatientDashboardPage.Web_Later_Button, 10);
                Generic_Utils.JavaScriptElementClick(laterButton);

                Wait.InvisibleOfElement(PatientDashboardPage.By_Notification_Popup, 10);

                Console.WriteLine("Popup closed successfully.");
            }

            catch (WebDriverTimeoutException)
            {

                Console.WriteLine("No popup displayed.");
            }
        }

        public static void NavigateToFindProviderPage()
        {
            IWebElement providerLink = Wait.ElementIsClickable(PatientDashboardPage.Web_Find_Provider_Link, 10);
            providerLink.Click();
        }

        public static void NavigateToActiveAppointment()
        {
            Generic_Utils.ScrollToMiddle();
            Generic_Utils.ScrollToElement(PatientDashboardPage.Web_Active_Appointment_View_All_Link);
            PatientDashboardPage.Web_Active_Appointment_View_All_Link.Click();
        }

        public static void NavigateToPatientProfile()
        {
            IWebElement patientProfileLink = Wait.ElementIsVisible(PatientDashboardPage.By_Update_Icon, 10);
            patientProfileLink.Click();
        }

        public static void NavigateToPatientProfileThroughProfilePicIcon()
        {
            PatientDashboardPage.Web_ProfilePic_Icon.Click();
        }

        public static void userLogout()
        {
            PatientDashboardPage.Web_Logout_Icon.Click();   
        }

        public static void ValidatePatientDetailInPatientDashboard(string fName, string lName, string weight, string height, string gender, string address, string suburb, string city, string province, string postalCode, string successText)
        {
            Patient_Profile_Page.SubmitPatientProfileInfo(fName, lName, weight, height, gender, address, suburb, city, province, postalCode, successText);
            string getProfileFullName = Patient_Profile_Page.GetFullName();
            string getProfileGender = Patient_Profile_Page.GetGender();
            string getProfileWeight = Patient_Profile_Page.GetWeight();
            string getProfileHeight = Patient_Profile_Page.GetHeight();
            string getProfileAddress = Patient_Profile_Page.GetFullAddress();

            Patient_Profile_Page.NavigateToDashboard();
            ValidatePatientDashboard();


            string nameText = PatientDashboardPage.Web_PatientName.Text;
            string genderText = PatientDashboardPage.Web_Patient_Gender.Text;
            string weightText = PatientDashboardPage.Web_Patient_Weight.Text;
            string heightText = PatientDashboardPage.Web_Patient_Height.Text;
            string addressText = PatientDashboardPage.Web_Patient_Address.Text;

            Assert.Multiple(() =>
            {
                Assert.That(getProfileFullName, Is.EqualTo(nameText));
                Assert.That(getProfileGender, Is.EqualTo(genderText));
                Assert.That(getProfileWeight, Does.Contain(weightText));
                Assert.That(getProfileHeight, Does.Contain(heightText));
                Assert.That(getProfileAddress, Is.EqualTo(addressText));
            });

            Reports.childLog.Log(Status.Info, "Patient Dashboard Information matched with Patient Profile Page");
            Generic_Utils.GetScreenshot("Profile Dashboard Personal Detail Section screenshot");
        }


        public static void NavigateToMedicalFiles()
        {
            IWebElement MedicalFilesLink = Wait.ElementIsVisible(PatientDashboardPage.By_MedicalFilesTab, 10);
            MedicalFilesLink.Click();
        }

        public static void Get_And_Validate_Patient_FullName(string Original_Text)
        {
            string Capture_Text = Generic_Utils.getText(PatientDashboardPage.Web_PatientName);
            Assert.That(Original_Text, Is.EqualTo(Capture_Text));
        }
        public static void Get_And_Validate_Patient_Weight(string Original_Text)
        {
            string Capture_Text = Generic_Utils.getText(PatientDashboardPage.Web_Patient_Weight);
            Assert.That(Original_Text, Is.EqualTo(Capture_Text));
        }
        public static void Get_And_Validate_Patient_Height(string Original_Text)
        {
            string Capture_Text = Generic_Utils.getText(PatientDashboardPage.Web_Patient_Height);
            Assert.That(Original_Text, Is.EqualTo(Capture_Text));
        }
        public static void Get_And_Validate_Patient_Gender(string Original_Text)
        {
            string Capture_Text = Generic_Utils.getText(PatientDashboardPage.Web_Patient_Gender);
            Assert.That(Original_Text, Is.EqualTo(Capture_Text));
        }
        public static void Get_And_Validate_Patient_Address(string Original_Text)
        {
            string Capture_Text = Generic_Utils.getText(PatientDashboardPage.Web_Patient_Address);
            Assert.That(Original_Text, Is.EqualTo(Capture_Text));
        }


        public static void ValidateDashboardAppointmentWithActiveAppointmentPage()
        {
            Generic_Utils.ScrollToMiddle();
            Generic_Utils.ScrollToElement(PatientDashboardPage.Web_UpcomingAppointmentHeader);
            var dashboardAppointmentList = PatientDashboardPage.Web_DashboardAppointmentList.Count;

            Reports.childLog.Log(Status.Info, "Getting Appointment Count From Patient Dashboard Page");
            Generic_Utils.GetScreenshot("Patient Dashboard Page Active Appointment Section Screenshot");

            if (dashboardAppointmentList == 0)
            {
                Console.WriteLine("Active appointment is not found");
            }
            else
            {
                Console.WriteLine("Active appointments are found");
                IWebElement dashboardViewAllLink = PatientDashboardPage.Web_Active_Appointment_View_All_Link;
                ScrollToElement(dashboardViewAllLink);
                dashboardViewAllLink.Click();

                Wait.ElementExist(ActiveAppointmentPage.By_Book_Appointment_Button, 10);
                int activeAppointmentCount = ActiveAppointmentPage.Web_Active_Appointment_Count.Count();

                Assert.That(activeAppointmentCount, Is.EqualTo(dashboardAppointmentList));

                Reports.childLog.Log(Status.Info, "Getting Appointment Count From Active Appointment Page");
                Generic_Utils.GetScreenshot("Active Appointment Page Screenshot");
            }
        }
        public static void ValidateInvoiceDetailsForPastAppointments(string ReferenceNumber)
        {
            Generic_Utils.ScrollToBottoms();

            IList<IWebElement> getAppointmentRecords = PatientDashboardPage.Web_AppointmentRecords;

            foreach (IWebElement appointment in getAppointmentRecords)
            {
                IWebElement appointmentReferenceNumber = appointment.FindElement(PatientDashboardPage.By_ReferenceNumber);
                string refNumber = appointmentReferenceNumber.Text;
                Console.WriteLine(refNumber);

                if (refNumber.Equals(ReferenceNumber))
                {
                    IWebElement viewInvoice = appointment.FindElement(PatientDashboardPage.By_ViewInvoiceButton);
                    Wait.ElementIsClickable(viewInvoice, 10);
                    viewInvoice.Click();
                    break;
                }
            }
            Generic_Utils.WindowHandle();
            Wait.ElementExist(PatientDashboardPage.By_InvoiceHeaderText, 10);
            IWebElement getInvoiceNumber = PatientDashboardPage.Web_InvoiceNumber;
            string invoiceNumberText = getInvoiceNumber.Text;
            string invoiceNumber = invoiceNumberText.Substring(invoiceNumberText.IndexOf('#'));
            Console.WriteLine(invoiceNumber);
            Assert.That(ReferenceNumber, Is.EqualTo(invoiceNumber));

            Reports.childLog.Log(Status.Info, "Invoice page is displayed");
            Generic_Utils.GetScreenshot("Invoice Page Screenshot");
        }

        public static void VerifyRatingsForPastAppointments(string ReferenceNumber, string rateValue, string ratingComment, string ratingExistMessage, string ratingSavedMessage)
        {
            Generic_Utils.ScrollToBottoms();

            IList<IWebElement> getAppointmentRecords = PatientDashboardPage.Web_AppointmentRecords;

            foreach (IWebElement appointment in getAppointmentRecords)
            {
                IWebElement appointmentReferenceNumber = appointment.FindElement(PatientDashboardPage.By_ReferenceNumber);
                string refNumber = appointmentReferenceNumber.Text;


                if (refNumber.Equals(ReferenceNumber))
                {
                    IWebElement ratingButton = appointment.FindElement(PatientDashboardPage.By_RatingButton);
                    ratingButton.Click();
                }
            }
            Wait.GenericWait(3000);

            string getRatingAlreadyExistText = PatientDashboardPage.Web_RatingExistText.Text;

            if (getRatingAlreadyExistText.Equals(ratingExistMessage))
            {
                Console.WriteLine("Rating already exist for this appointment ");
                Reports.childLog.Log(Status.Info, "Rating already exist popup is displayed");
                Generic_Utils.GetScreenshot("Rating already exist popup Screenshot");
            }
            else
            {
                IWebElement ratingStar = PatientDashboardPage.Web_StarRatings(rateValue);
                ratingStar.Click();

                PatientDashboardPage.Web_RatingComment.SendKeys(ratingComment);
                PatientDashboardPage.Web_RatingSaveButton.Click();

                Wait.ElementIsVisible(PatientDashboardPage.By_RatingExistText, 10);
                string getRatingSavedMessage = PatientDashboardPage.Web_RatingExistText.Text;
                Assert.That(ratingSavedMessage, Is.EqualTo(getRatingSavedMessage));

                Reports.childLog.Log(Status.Info, "Rating saved popup is displayed");
                Generic_Utils.GetScreenshot("Rating saved popup Screenshot");
            }
        }

        public static void ValidateRepeatPrescriptionJourney(int doctorId, string appointmentNumber, string doctorPopupText, string appointmentPopupText, string voucherCode, string voucherSuccessMessage)
        {
            DateTime? dateCreated;
            ScrollToBottoms();

            IList<IWebElement> getAppointmentRecords = PatientDashboardPage.Web_AppointmentRecords;
            bool isActionCompleted = false;
            foreach (IWebElement appointment in getAppointmentRecords)
            {
                IWebElement appointmentReferenceNumber = appointment.FindElement(PatientDashboardPage.By_ReferenceNumber);
                string refNumber = appointmentReferenceNumber.Text;


                if (refNumber.Equals(appointmentNumber))
                {
                    IList<IWebElement> repeatRequestButton = appointment.FindElements(PatientDashboardPage.By_RepeatRequestButton);

                    if (repeatRequestButton.Count > 0 && repeatRequestButton[0].Displayed)
                    {
                        repeatRequestButton[0].Click();
                        bool isDoctorAvailable = Database_Utils.GetDoctorAndAppointmentDetail(doctorId, appointmentNumber, out dateCreated);

                        if (!isDoctorAvailable)
                        {
                            Console.WriteLine("Provider is not available.");
                            Wait.ElementIsVisible(PatientDashboardPage.By_DoctorNotAvailableHeader, 5);
                            string popupText = PatientDashboardPage.Web_DoctorNotAvailablePopupText.Text;
                            StringAssert.Contains(doctorPopupText, popupText);

                            Reports.childLog.Log(Status.Info, "Provider no longer available popup is displayed ");
                            Generic_Utils.GetScreenshot("Provider no longer available Screenshot");

                        }
                        else if (dateCreated.HasValue)
                        {
                            DateTime appointmentDate = dateCreated.Value.Date;
                            if ((DateTime.Now - dateCreated.Value).TotalDays > 90)
                            {
                                Console.WriteLine("Appointment is older than 3 months.");
                                Wait.ElementIsVisible(PatientDashboardPage.By_DoctorNotAvailableHeader, 5);
                                string getPopupText = PatientDashboardPage.Web_PastThreeMonthAppointmentPopupText.Text;
                                Assert.That(getPopupText, Is.EqualTo(appointmentPopupText));

                                Reports.childLog.Log(Status.Info, "Past Three Month Appointment popup is displayed ");
                                Generic_Utils.GetScreenshot("Past Three Month Appointment Screenshot");
                            }
                            else
                            {
                                Wait.GenericWait(2000);
                                Generic_Utils.IsElementDisplayed(PatientDashboardPage.By_CheckOutPageElement);

                                CheckoutPage.Web_Voucher_TextBox.SendKeys(voucherCode);
                                CheckoutPage.Web_Voucher_Consent_Checkbox.Click();
                                CheckoutPage.Web_Voucher_Apply_Button.Click();
                                Wait.ElementIsVisible(CheckoutPage.By_Voucher_Success_Message_Text, 5);

                                string voucherSuccessText = CheckoutPage.Web_Voucher_Success_Message_Text.Text;
                                Assert.That(voucherSuccessText, Is.EqualTo(voucherSuccessMessage));

                                ScrollToBottoms();
                                PatientDashboardPage.Web_Repeat_Prescription_Submit_Button.Click();

                                Reports.childLog.Log(Status.Info, "Repeat Prescription Journey is Completed ");
                                Generic_Utils.GetScreenshot("Repeat Prescription Journey Confirmation Page Screenshot");

                            }
                        }
                        isActionCompleted = true;
                        break;

                    }
                    else
                    {
                        // Handle the case where the button is not found
                        Console.WriteLine("Repeat request button is not found for the respective appointment.");
                        Reports.childLog.Log(Status.Info, "Repeat Prescription Button is not Available as Doctor doesn't Prescribe the Prescription ");
                        Generic_Utils.GetScreenshot("Appointment History Screenshot");
                    }
                }
            }
        }
        public static FileInfo GetLatestFile(string folderPath, string[] fileExtensions, DateTime downloadStartTime)
        {
            DirectoryInfo directory = new DirectoryInfo(folderPath);

            // Fetch files matching the extensions and created after the download started
            var files = directory.GetFiles()
                                 .Where(f => fileExtensions.Contains(f.Extension.ToLower()) &&
                                             f.LastWriteTime >= downloadStartTime)
                                 .OrderByDescending(f => f.LastWriteTime)
                                 .ToList();

            return files.FirstOrDefault();
        }

        public static void ValidatePrescription(string appointmentNumber, string filePath, string[] acceptableExtensions, string prescriptionPopupText)
        {
            Generic_Utils.ScrollToBottoms();
            IList<IWebElement> getAppointmentRecords = PatientDashboardPage.Web_AppointmentRecords;
            bool isProcessed = false;
            DateTime downloadStartTime = DateTime.Now;
            foreach (IWebElement appointment in getAppointmentRecords)
            {
                IWebElement appointmentReferenceNumber = appointment.FindElement(PatientDashboardPage.By_ReferenceNumber);
                string refNumber = appointmentReferenceNumber.Text;

                if (refNumber.Equals(appointmentNumber))
                {
                    IWebElement prescriptionButton = appointment.FindElement(PatientDashboardPage.By_Download_Prescription_Button);
                    Wait.ElementIsClickable(prescriptionButton,5).Click();
                    isProcessed = true;
                    break;
                }
            }
            if (isProcessed)
            {
                Wait.WaitForFile(filePath, 10, acceptableExtensions, downloadStartTime);
                var downloadedFile = GetLatestFile(filePath, acceptableExtensions, downloadStartTime);

                if (downloadedFile != null)
                {
                    Assert.That(downloadedFile.Length > 0, "Downloaded file is empty.");
                    Console.WriteLine($"Prescription downloaded successfully: {downloadedFile.Name}");
                }
                else
                {
                    try
                    {
                        Console.WriteLine("Prescription is not found for the respective appointment");
                        Wait.ElementIsVisible(PatientDashboardPage.By_Prescription_Popup_Header, 5);
                        string popupText = PatientDashboardPage.Web_Prescription_Popup_Text.Text;
                        Assert.That(prescriptionPopupText, Is.EqualTo(popupText));
                    }
                    catch (WebDriverTimeoutException)
                    {
                        Console.WriteLine("No popup appeared; prescription might not be available.");
                    }
                }
            }
           
        }
        public static void ValidateSickNote(string appointmentNumber, string filePath, string[] acceptableExtensions, string sickNotePopupText)
        {
            Generic_Utils.ScrollToBottoms();
            IList<IWebElement> getAppointmentRecords = PatientDashboardPage.Web_AppointmentRecords;
            bool isProcessed = false;
            DateTime downloadStartTime = DateTime.Now;
            foreach (IWebElement appointment in getAppointmentRecords)
            {
                IWebElement appointmentReferenceNumber = appointment.FindElement(PatientDashboardPage.By_ReferenceNumber);
                string refNumber = appointmentReferenceNumber.Text;

                if (refNumber.Equals(appointmentNumber))
                {
                    IWebElement downloadSicknoteButton = appointment.FindElement(PatientDashboardPage.By_Download_Sick_Note);
                    Wait.ElementIsClickable(downloadSicknoteButton, 5).Click();
                    isProcessed = true; 
                    break;
                }
            }
            if (isProcessed)
            {
                Wait.WaitForFile(filePath, 10, acceptableExtensions, downloadStartTime);
                var downloadedFile = GetLatestFile(filePath, acceptableExtensions, downloadStartTime);

                if (downloadedFile != null)
                {
                    Assert.That(downloadedFile.Length > 0, "Downloaded file is empty.");
                    Console.WriteLine($"Sick Note downloaded successfully: {downloadedFile.Name}");
                }
                else
                {
                    try
                    {
                        Console.WriteLine("Sick Note is not found for the respective appointment");
                        Wait.ElementIsVisible(PatientDashboardPage.By_SickNote_Popup_Header, 5);
                        string popupText = PatientDashboardPage.Web_SickNote_Popup_Text.Text;
                        Assert.That(sickNotePopupText, Is.EqualTo(popupText));
                    }
                    catch (WebDriverTimeoutException)
                    {
                        Console.WriteLine("No popup appeared; sick note might not be available.");
                    }
                }
            }
        }
    }

}
