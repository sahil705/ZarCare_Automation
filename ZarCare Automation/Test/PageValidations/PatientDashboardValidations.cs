namespace ZarCare_Automation.Test.PageValidations
{
    public class PatientDashboardValidations
    {
        public static string PatientProfileJson = "PatientProfile";
        public static string Login = "LoginData";
        public static string DashboardJson = "Dashboard";
        public static string Appointment = "BookAppointments";

        public static void ValidatePatientDetail()
        {
            var json = Json_Reader.GetDataFromJson(PatientProfileJson);
            var loginJson = Json_Reader.GetArrayFromJson(Login, "ValidLoginData");
            string firstName = json["First_Name"].ToString();
            string lastName = json["Last_Name"].ToString();
            string patientWeight = json["Weight"].ToString();
            string patientHeight = json["Height"].ToString();
            string patientGender = json["Gender"].ToString();
            string patientAddress = json["Address"].ToString();
            string patientSuburb = json["Suburb"].ToString();
            string patientCity = json["City"].ToString();
            string patientProvince = json["Province"].ToString();
            string postalCode = json["PostalCode"].ToString();
            string successMessage = json["Success_Message"].ToString();
            string userEmail = loginJson[0]["Login_Patient_Email"].ToString();
            string userPassword = loginJson[0]["Login_Patient_Password"].ToString();
            string userCell = loginJson[0]["Patient_CellPhone"].ToString();


            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Patient Detail On Patient Dashboard ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page and Patient Login ");
            Home_Page.NavigateToLoginPage();    
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(userEmail, userPassword);

            Reports.childLog.Log(Status.Info, "Step 3: Check the Email and Cellphone Status ");
            bool status = Login_Page.Get_EmailAndCellPhone_Status(userEmail, userCell);
            if (status == true)
            {
                Reports.childLog.Log(Status.Info, "Step 4: Validate the Patient Dashboard ");
                Patient_Dashboard_Page.ValidatePatientDashboard();
                Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
                Reports.childLog.Log(Status.Info, "Step 5: Submit Patient Profile and Validate on the Patient Dashboard ");
                Patient_Dashboard_Page.NavigateToPatientProfile();
                Patient_Profile_Page.ValidatePatientProfile();
                Patient_Dashboard_Page.ValidatePatientDetailInPatientDashboard(firstName, lastName, patientWeight, patientHeight, patientGender, patientAddress, patientSuburb, patientCity, patientProvince, postalCode, successMessage);
            }
            else
            {
                Reports.childLog.Log(Status.Info, "Step 4: Redirects to Email and Cellphone Verification Page");
                Patient_Dashboard_Page.ValidateUnverifiedDashboard();
                Patient_Dashboard_Page.userLogout();
            }

            Reports.childLog.Log(Status.Info, "=================================================");

        }

        public static void ValidateRedirectionToPatientProfile()
        {
            var loginJson = Json_Reader.GetArrayFromJson(Login, "ValidLoginData");
            string userEmail = loginJson[0]["Login_Patient_Email"].ToString();
            string userPassword = loginJson[0]["Login_Patient_Password"].ToString();
            string userCell = loginJson[0]["Patient_CellPhone"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Patient Profile Page Through Profile Pic Icon On Dashboard ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page and Patient Login  ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(userEmail, userPassword);

            Reports.childLog.Log(Status.Info, "Step 3: Check the Email and Cellphone Status ");
            bool status = Login_Page.Get_EmailAndCellPhone_Status(userEmail, userCell);
            
            if (status == true)
            {
                Reports.childLog.Log(Status.Info, "Step 4: Validate Redirection on the Patient Dashboard Through Profile Pic icon ");
                Patient_Dashboard_Page.ValidatePatientDashboard();
                Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
                Patient_Dashboard_Page.NavigateToPatientProfileThroughProfilePicIcon();
                Patient_Profile_Page.ValidatePatientProfile();
            }
            else
            {
                Reports.childLog.Log(Status.Info, "Step 4: Redirects to Email and Cellphone Verification Page");
                Patient_Dashboard_Page.ValidateUnverifiedDashboard();
                Patient_Dashboard_Page.userLogout();
            }
            

            Reports.childLog.Log(Status.Info, "=================================================");

        }

        public static void ValidatePatientProfileOnDashboard()
        {
            var Json = Json_Reader.GetDataFromJson(PatientProfileJson);

            string patientName = Json["Patient_Name"].ToString();
            string patientHeight = Json["Patient_Height"].ToString();
            string patientWeight = Json["Patient_Weight"].ToString();
            string patientGender = Json["Patient_Gender"].ToString();
            string patientFullAddress = Json["Patient_FullAddress"].ToString();

            PatientProfileValidations.SubmitPatientProfileDetails();

            Reports.childLog.Log(Status.Info, "Step 4: Verify patient details on dashboard page");
            Patient_Profile_Page.NavigateToDashboard();
            Patient_Dashboard_Page.Get_And_Validate_Patient_FullName(patientName);
            Patient_Dashboard_Page.Get_And_Validate_Patient_Height(patientHeight);
            Patient_Dashboard_Page.Get_And_Validate_Patient_Weight(patientWeight);
            Patient_Dashboard_Page.Get_And_Validate_Patient_Gender(patientGender);
            Patient_Dashboard_Page.Get_And_Validate_Patient_Address(patientFullAddress);

            Reports.childLog.Log(Status.Info, "=================================================");

        }
        public static void ValidateAppointmentCount()
        {
            var loginJson = Json_Reader.GetArrayFromJson(Login, "ValidLoginData");
            string userEmail = loginJson[0]["Login_Patient_Email"].ToString();
            string userPassword = loginJson[0]["Login_Patient_Password"].ToString();
            string userCell = loginJson[0]["Patient_CellPhone"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Dashboard Active Appointment With Active Appointment Page ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page and Patient Login");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(userEmail, userPassword);

            Reports.childLog.Log(Status.Info, "Step 3: Check the Email and Cellphone Status ");
            bool status = Login_Page.Get_EmailAndCellPhone_Status(userEmail, userCell);

            if (status == true)
            {
                Reports.childLog.Log(Status.Info, "Step 4: Get Dashboard Active Appointment Count and Validate With Active Appointment Page ");
                Patient_Dashboard_Page.ValidatePatientDashboard();
                Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
                Patient_Dashboard_Page.ValidateDashboardAppointmentWithActiveAppointmentPage();
            }
            else
            {
                Reports.childLog.Log(Status.Info, "Step 4: Redirects to Email and Cellphone Verification Page");
                Patient_Dashboard_Page.ValidateUnverifiedDashboard();
                Patient_Dashboard_Page.userLogout();
            }


            Reports.childLog.Log(Status.Info, "=================================================");
        }


        public static void ValidateInvoiceFromDashboard()
        {
            var dashboardJson = Json_Reader.GetDataFromJson(DashboardJson);
            var loginJson = Json_Reader.GetArrayFromJson(Login, "ValidLoginData");
            string userEmail = loginJson[0]["Login_Patient_Email"].ToString();
            string userPassword = loginJson[0]["Login_Patient_Password"].ToString();
            string userCell = loginJson[0]["Patient_CellPhone"].ToString();
            string referenceNumber = dashboardJson["AppointmentReferenceCode"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Invoice from Patient Dashboard Page");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page and Patient Login ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(userEmail, userPassword);

            Reports.childLog.Log(Status.Info, "Step 3: Check the Email and Cellphone Status ");
            bool status = Login_Page.Get_EmailAndCellPhone_Status(userEmail, userCell);

            if (status == true)
            {
                Reports.childLog.Log(Status.Info, "Step 4: Validate the Invoice");
                Patient_Dashboard_Page.ValidatePatientDashboard();
                Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
                Patient_Dashboard_Page.ValidateInvoiceDetailsForPastAppointments(referenceNumber);
            }
            else
            {
                Reports.childLog.Log(Status.Info, "Step 4: Redirects to Email and Cellphone Verification Page");
                Patient_Dashboard_Page.ValidateUnverifiedDashboard();
                Patient_Dashboard_Page.userLogout();
            }

            

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void PatientRateToDoctorAfterAppointment()
        { 
            var dashboardJson = Json_Reader.GetDataFromJson(DashboardJson);
            var loginJson = Json_Reader.GetArrayFromJson(Login, "ValidLoginData");
            string userEmail = loginJson[0]["Login_Patient_Email"].ToString();
            string userPassword = loginJson[0]["Login_Patient_Password"].ToString();
            string userCell = loginJson[0]["Patient_CellPhone"].ToString();
            string referenceNumber = dashboardJson["AppointmentReferenceCode"].ToString();
            string starValue = dashboardJson["RateValue"].ToString();
            string ratingComment = dashboardJson["RatingComment"].ToString();
            string ratingExistMessage = dashboardJson["RatingExistMessage"].ToString();
            string ratingSavedMessage = dashboardJson["RatingSavedMessage"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Verify Patient Rating to Doctor");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page and Patient Login  ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(userEmail, userPassword);

            Reports.childLog.Log(Status.Info, "Step 3: Check the Email and Cellphone Status ");
            bool status = Login_Page.Get_EmailAndCellPhone_Status(userEmail, userCell);

            if (status == true)
            {
                Reports.childLog.Log(Status.Info, "Step 4: Validate the Ratings");
                Patient_Dashboard_Page.ValidatePatientDashboard();
                Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
                Patient_Dashboard_Page.VerifyRatingsForPastAppointments(referenceNumber, starValue, ratingComment, ratingExistMessage, ratingSavedMessage);
            }
            else
            {
                Reports.childLog.Log(Status.Info, "Step 4: Redirects to Email and Cellphone Verification Page");
                Patient_Dashboard_Page.ValidateUnverifiedDashboard();
                Patient_Dashboard_Page.userLogout();
            }
            

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void VerifyRepeatPrescriptionJourney()
        {
            var dashboardJson = Json_Reader.GetDataFromJson(DashboardJson);
            var appointmentJson = Json_Reader.GetDataFromJson(Appointment);
            var loginJson = Json_Reader.GetArrayFromJson(Login, "ValidLoginData");
            string userEmail = loginJson[0]["Login_Patient_Email"].ToString();
            string userPassword = loginJson[0]["Login_Patient_Password"].ToString();
            string userCell = loginJson[0]["Patient_CellPhone"].ToString();
            int doctorId = Convert.ToInt32(dashboardJson["DoctorProfileId"]);
            string appointmentNumber = dashboardJson["AppointmentReferenceCode"].ToString();
            string doctorAvailablePopup = dashboardJson["DoctorAvaliabilityPopup"].ToString();
            string pastAppointmentPopup = dashboardJson["PastThreeMonthAppointmentPopup"].ToString();
            string voucherCode = appointmentJson["Voucher_Code"].ToString();
            string voucherSuccessMessage = appointmentJson["Voucher_Success_Message"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Verify Patient Repeat Prescription Journey ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page and Patient Login  ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(userEmail, userPassword);

            Reports.childLog.Log(Status.Info, "Step 3: Check the Email and Cellphone Status ");
            bool status = Login_Page.Get_EmailAndCellPhone_Status(userEmail, userCell);

            if (status == true)
            {
                Reports.childLog.Log(Status.Info, "Step 4: Validate the Repeat Prescription Journey ");
                Patient_Dashboard_Page.ValidatePatientDashboard();
                Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
                Patient_Dashboard_Page.ValidateRepeatPrescriptionJourney(doctorId, appointmentNumber, doctorAvailablePopup, pastAppointmentPopup, voucherCode, voucherSuccessMessage);
            }
            else
            {
                Reports.childLog.Log(Status.Info, "Step 4: Redirects to Email and Cellphone Verification Page");
                Patient_Dashboard_Page.ValidateUnverifiedDashboard();
                Patient_Dashboard_Page.userLogout();
            }
            

            Reports.childLog.Log(Status.Info, "=================================================");

        }
        public static void ValidatePrescriptionForPastAppointments()
        {
            var dashboardJson = Json_Reader.GetDataFromJson(DashboardJson);
            var dashboardJsonArray = Json_Reader.GetArrayFromJson(DashboardJson,"Acceptable_Format");
            var loginJson = Json_Reader.GetArrayFromJson(Login, "ValidLoginData");
            string userEmail = loginJson[0]["Login_Patient_Email"].ToString();
            string userPassword = loginJson[0]["Login_Patient_Password"].ToString();
            string userCell = loginJson[0]["Patient_CellPhone"].ToString();
            string appointmentNumber = dashboardJson["AppointmentReferenceCode"].ToString();
            string filePath = dashboardJson["Download_Path"].ToString();
            string prescriptionPopupMessage = dashboardJson["Prescription_Popup_Text"].ToString();
            string[] acceptableExtensions = dashboardJsonArray.ToObject<string[]>();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Verify the Prescription Functionality for the Past Appointments ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page and Patient Login ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(userEmail, userPassword);

            Reports.childLog.Log(Status.Info, "Step 3: Check the Email and Cellphone Status ");
            bool status = Login_Page.Get_EmailAndCellPhone_Status(userEmail, userCell);

            if (status == true)
            {
                Reports.childLog.Log(Status.Info, "Step 3: Click on the Download Prescription Button and Validate the Prescription ");
                Patient_Dashboard_Page.ValidatePatientDashboard();
                Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
                Patient_Dashboard_Page.ValidatePrescription(appointmentNumber, filePath, acceptableExtensions, prescriptionPopupMessage);
            }
            else
            {
                Reports.childLog.Log(Status.Info, "Step 4: Redirects to Email and Cellphone Verification Page");
                Patient_Dashboard_Page.ValidateUnverifiedDashboard();
                Patient_Dashboard_Page.userLogout();
            }
           

            Reports.childLog.Log(Status.Info, "=================================================");
        }
        public static void ValidateSickNoteForPastAppointments()
        {
            var dashboardJson = Json_Reader.GetDataFromJson(DashboardJson);
            var dashboardJsonArray = Json_Reader.GetArrayFromJson(DashboardJson, "Acceptable_Format");
            var loginJson = Json_Reader.GetArrayFromJson(Login, "ValidLoginData");
            string userEmail = loginJson[0]["Login_Patient_Email"].ToString();
            string userPassword = loginJson[0]["Login_Patient_Password"].ToString();
            string userCell = loginJson[0]["Patient_CellPhone"].ToString();
            string appointmentNumber = dashboardJson["AppointmentReferenceCode"].ToString();
            string filePath = dashboardJson["Download_Path"].ToString();
            string sickNotePopupMessage = dashboardJson["SickNote_Popup_Text"].ToString();
            string[] acceptableExtensions = dashboardJsonArray.ToObject<string[]>();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Verify the Sick Note Functionality for the Past Appointments ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page and Patient Login ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(userEmail, userPassword);

            Reports.childLog.Log(Status.Info, "Step 3: Check the Email and Cellphone Status ");
            bool status = Login_Page.Get_EmailAndCellPhone_Status(userEmail, userCell);

            if (status == true)
            {
                Reports.childLog.Log(Status.Info, "Step 3: Click on the Download Sick Note Button and Validate the Sick Note ");
                Patient_Dashboard_Page.ValidatePatientDashboard();
                Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
                Patient_Dashboard_Page.ValidateSickNote(appointmentNumber, filePath, acceptableExtensions, sickNotePopupMessage);
            }
            else
            {
                Reports.childLog.Log(Status.Info, "Step 4: Redirects to Email and Cellphone Verification Page");
                Patient_Dashboard_Page.ValidateUnverifiedDashboard();
                Patient_Dashboard_Page.userLogout();
            }

            Reports.childLog.Log(Status.Info, "=================================================");
        }
    }
}
