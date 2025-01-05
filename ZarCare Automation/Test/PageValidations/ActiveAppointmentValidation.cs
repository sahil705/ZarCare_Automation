namespace ZarCare_Automation.Test.PageValidations
{
    public class ActiveAppointmentValidation
    {
        public static string LoginJson = "Login";
        public static string Appointment = "BookAppointments";
        public static string register = "Register";

        public static void Book_Appointment_Through_Portal()
        {
            var json = Json_Reader.GetDataFromJson(Appointment);
            var loginJson = Json_Reader.GetDataFromJson(LoginJson);
            string email = loginJson["Email"].ToString();
            string password = loginJson["Password"].ToString();
            string provider_Name = json["Provider_Name"].ToString();
            string appointmentDate = json["Provider_Appointment_Date"].ToString();
            string appointmentTime = json["Provider_Appointment_Time"].ToString();
            string confirmationText = json["Confirmation_Capture_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Appointment Booking Journey for Registered/Logged In Patients ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToLoginPage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the login page and Patient Login into the website ");
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(email, password);

            Reports.childLog.Log(Status.Info, "Step 3: Navigate the Patient Dashboard page and Validate the Patient Dashboard ");
            Patient_Dashboard_Page.ValidatePatientDashboard();
            Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
            Patient_Dashboard_Page.NavigateToFindProviderPage();

            Reports.childLog.Log(Status.Info, "Step 4: Validate the Find Provider page and Search Provider and Select slot ");
            Find_Provider_Page.Validate_Find_Provider_Page();
            Find_Provider_Page.Search_Provider();
            Find_Provider_Page.Get_Provider_From_List(provider_Name);
            Find_Provider_Page.Click_On_Appointment_Date(appointmentDate, appointmentTime);

            Reports.childLog.Log(Status.Info, "Step 5: Validate and Proceed with the Checkout page ");
            CheckOut_Page.Validate_CheckOut();
            CheckOut_Page.Add_Symptom_And_Click_On_Continue_Button();

            Reports.childLog.Log(Status.Info, "Step 6: Validate and Proceed with the Payment page ");
            Payment_Page.Validate_Payment();
            Payment_Page.Click_On_Payment_Page();

            Reports.childLog.Log(Status.Info, "Step 7: Appointment Booked Successfully Validate Payment Confirmation page ");
            Payment_Confirmation_Page.Validate_Payment_Confirmation();
            Payment_Confirmation_Page.Get_And_Validate_Confirmation_Page_Text(confirmationText);

            Reports.childLog.Log(Status.Info, "=================================================");

        }

        public static void Book_Appointment_Through_Public_Website()
        {
            var bookAppoitmentJson = Json_Reader.GetDataFromJson(Appointment);
            var registerJson = Json_Reader.GetDataFromJson(register);

            string doctorName = bookAppoitmentJson["Doctor_Name"].ToString();
            string appointmentDate = bookAppoitmentJson["Appointment_Date"].ToString();
            string appointmentTime = bookAppoitmentJson["Appointment_Time"].ToString();
            string confirmationText = bookAppoitmentJson["Confirmation_Capture_Text_Public"].ToString();

            string firstName = registerJson["First_Name"].ToString();
            string surName = registerJson["Sur_Name"].ToString();
            string cellNumber = registerJson["CellPhone_Number"].ToString();
            string emailAddress = registerJson["Email_Address"].ToString();
            string password = registerJson["Pass_Word"].ToString();
            string confirmPassword = registerJson["Confirm_Password"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Appointment Booking Journey for Public Patients ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate Home Page and Navigate to Our Provider Page ");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToConsultNow();

            Reports.childLog.Log(Status.Info, "Step 2: Search and Fetch Doctor from the List ");
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Search_Doctor(doctorName);
            Our_Providers_Page.FetchDoctorFromList(doctorName);
            
            Reports.childLog.Log(Status.Info, "Step 3: Validate Doctor Profile and Book Appointment ");
            Doctor_Profile_Page.ValidateDoctorProfile();
            Doctor_Profile_Page.BookAppointment(appointmentDate, appointmentTime);

            Reports.childLog.Log(Status.Info, "Step 4: Complete the Registration Journey  ");
            Register_Page.Validate_RegisterPage();
            Register_Page.Patient_Registration(firstName, surName, cellNumber, emailAddress, password, confirmPassword);
            Otp_Page.Validate_Otp_Page();
            Otp_Page.Enter_and_Submit_Otp();

            Reports.childLog.Log(Status.Info, "Step 5: Validate and Proceed with the Checkout page ");
            CheckOut_Page.Validate_CheckOut();
            CheckOut_Page.Public_Booking_Continue_Button();

            Reports.childLog.Log(Status.Info, "Step 6: Validate and Proceed with the Payment page ");
            Payment_Page.Validate_Payment();
            Payment_Page.Click_On_Payment_Page();

            Reports.childLog.Log(Status.Info, "Step 7: Appointment Booked Successfully and Validate Confirmation Message ");
            Payment_Confirmation_Page.Validate_Payment_Confirmation();
            Payment_Confirmation_Page.Get_And_Validate_Confirmation_Page_Text(confirmationText);

            Reports.childLog.Log(Status.Info, "=================================================");

        }
        public static void HandleMedicalFileStatusAndRedirection()
        {
            var loginJson = Json_Reader.GetDataFromJson(LoginJson);
            var json = Json_Reader.GetDataFromJson(Appointment);
            string patientEmail = loginJson["Email"].ToString();
            string patientPassword = loginJson["Password"].ToString();
            string appointmentNumber = json["Appointment_Reference_Code"].ToString();
            string patientName = json["Patient_Name"].ToString();
            string medicalFilePopupText = json["Incomplete_Medical_File_Popup_Text"].ToString();


            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Patient Detail On Patient Dashboard ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Login as a Patient and Validate the Patient Dashboard ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(patientEmail, patientPassword);
            Patient_Dashboard_Page.ValidatePatientDashboard();

            Reports.childLog.Log(Status.Info, "Step 3: Verify the Medical File Status and Navigate to View Detail Page ");
            Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
            ActiveAppointment_Page.ValidateMedicalFileStatusAndNavigateToViewDetail(appointmentNumber, patientName, medicalFilePopupText);

            Reports.childLog.Log(Status.Info, "=================================================");
        }
    }
}
