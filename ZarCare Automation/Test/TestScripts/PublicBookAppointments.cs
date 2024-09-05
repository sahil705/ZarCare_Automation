namespace ZarCare_Automation.Test.TestScripts
{
    public class PublicBookAppointments : Base
    {
        public string classname = "BookAppointments";
        public string registerFile = "Register";

        [Test]
        public void Book_Appointments()
        {
            var bookAppoitmentJson = Json_Reader.GetDataFromJson(classname);
            var registerJson = Json_Reader.GetDataFromJson(registerFile);
            
            string doctorName = bookAppoitmentJson["Doctor_Name"].ToString();
            string appointmentDate = bookAppoitmentJson["Appointment_Date"].ToString();
            string appointmentTime = bookAppoitmentJson["Appointment_Time"].ToString();
            string voucherCode = bookAppoitmentJson["Voucher_Code"].ToString();
            string originalText = bookAppoitmentJson["Voucher_Success_Message"].ToString();
            string confirmationText = bookAppoitmentJson["Confirmation_Capture_Text"].ToString();

            string firstName = registerJson["First_Name"].ToString();
            string surName = registerJson["Sur_Name"].ToString();
            string cellNumber = registerJson["CellPhone_Number"].ToString();
            string emailAddress = registerJson["Email_Address"].ToString();
            string password = registerJson["Pass_Word"].ToString();
            string confirmPassword = registerJson["Confirm_Password"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Our Provider Page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToConsultNow();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Search doctor");
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Search_Doctor(doctorName);
            Our_Providers_Page.FetchDoctorFromList(doctorName);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Validate Doctor Profile and Book Appointment");
            Doctor_Profile_Page.ValidateDoctorProfile();
            Doctor_Profile_Page.BookAppointment(appointmentDate, appointmentTime);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 4: Validate Register page and register patient");
            Register_Page.Validate_RegisterPage();
            Register_Page.Patient_Registration(firstName, surName, cellNumber, emailAddress, password, confirmPassword);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 5: Navigate to OTP Page and Submit the Otp");
            Otp_Page.Validate_Otp_Page();
            Otp_Page.Enter_and_Submit_Otp();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 6: Validate and Proceed with the Checkout page");
            CheckOut_Page.Validate_CheckOut();
            CheckOut_Page.Voucher_Apply_And_Get_Success_Message(voucherCode, originalText);
            CheckOut_Page.Public_Booking_Continue_Button();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 7: Validate and Proceed with the Payment page");
            Payment_Page.Validate_Payment();
            Payment_Page.Click_On_Payment_Page();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 8: Validate Payment Confirmation page ");
            Payment_Confirmation_Page.Validate_Payment_Confirmation();
            Payment_Confirmation_Page.Get_And_Validate_Confirmation_Page_Text(confirmationText);
            Reports.FlushNode(Reports.childLog);

        }
    }
}