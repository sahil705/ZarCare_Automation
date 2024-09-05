namespace ZarCare_Automation.Test.TestScripts
{
    public class PortalBookAppointment:Base
    {
        public string classname = "BookAppointments";

        [Test]
        public void Book_Appointment_Through_Portal()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string email = json["Email"].ToString();
            string password = json["Password"].ToString();
            string provider_Name = json["Provider_Name"].ToString();
            string appointmentDate = json["Provider_Appointment_Date"].ToString();
            string appointmentTime = json["Provider_Appointment_Time"].ToString();
            string voucherCode = json["Voucher_Code"].ToString();
            string originalText = json["Voucher_Success_Message"].ToString();
            string confirmationText = json["Confirmation_Capture_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Login Page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToLoginPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate the login page and Patient Login into the website");
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(email, password);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Navigate the Patient Profile page and Validate the page");
            Patient_Profile_Page.ValidatePatientProfile();
            Patient_Profile_Page.NavigateToFindProviderPage();  
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 4: Validate the Find Provider page and Search Provider and Select slot");
            Find_Provider_Page.Validate_Find_Provider_Page();
            Find_Provider_Page.Search_Provider();
            Find_Provider_Page.Get_Provider_From_List(provider_Name);
            Find_Provider_Page.Click_On_Appointment_Date(appointmentDate, appointmentTime);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 5: Validate and Proceed with the Checkout page");
            CheckOut_Page.Validate_CheckOut();
            CheckOut_Page.Voucher_Apply_And_Get_Success_Message(voucherCode, originalText);
            CheckOut_Page.Add_Symptom_And_Click_On_Continue_Button();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 6: Validate and Proceed with the Payment page");
            Payment_Page.Validate_Payment();
            Payment_Page.Click_On_Payment_Page();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 7: Validate Payment Confirmation page ");
            Payment_Confirmation_Page.Validate_Payment_Confirmation();
            Payment_Confirmation_Page.Get_And_Validate_Confirmation_Page_Text(confirmationText);
            Reports.FlushNode(Reports.childLog);
        }
    }
}
