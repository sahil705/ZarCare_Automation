
namespace ZarCare_Automation.Test.PageValidations
{
    public class RegisterPageValidation
    {

        public static string Classname = "Register";

    
        public static void Enter_Patient_Detaill_On_Registration_Page()
        {
            var json = Json_Reader.GetArrayFromJson(Classname, "Valid_PatientDetail");
            string firstName = json[0]["First_Name"].ToString();
            string surName = json[1]["Sur_Name"].ToString();
            string cellNumber = json[2]["CellPhone_Number"].ToString();
            string emailAddress = json[3]["Email_Address"].ToString();
            string password = json[4]["Pass_Word"].ToString();
            string confirmPassword = json[5]["Confirm_Password"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Validate the homepage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Login Page and Validate the Login page ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Navigate to Register Page and Patient Registration ");
            Login_Page.Navigate_To_RegisterPage();
            Register_Page.Validate_RegisterPage();
            Register_Page.Patient_Registration(firstName, surName, cellNumber, emailAddress, password, confirmPassword);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Navigate to OTP Page and Submit the Otp");
            Otp_Page.Validate_Otp_Page();
            Otp_Page.Enter_and_Submit_Otp();
            Login_Page.Validate_LoginPage();
            Reports.FlushNode(Reports.childLog);
        }
        public static void VerifyMemeberRedirectTo_OTP_pageAfterRegistrationDetail()
        {
            var json = Json_Reader.GetArrayFromJson(Classname, "Valid_PatientDetail");
       
            string firstName = json[0]["First_Name"].ToString();
            string surName = json[1]["Sur_Name"].ToString();
            string cellNumber = json[2]["CellPhone_Number"].ToString();
            string emailAddress = json[3]["Email_Address"].ToString();
            string password = json[4]["Pass_Word"].ToString();
            string confirmPassword = json[5]["Confirm_Password"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Validate the homepage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Login Page and Validate the Login page ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Navigate to Register Page and validate OTP page");
            Login_Page.Navigate_To_RegisterPage();
            Register_Page.Validate_RegisterPage();
            Register_Page.Patient_Registration(firstName, surName, cellNumber, emailAddress, password, confirmPassword);
            Otp_Page.Validate_Otp_Page();

        }
        public static void VerifyValidationMessageWithInvalidRegistrationFormDetail()
        {
            var json = Json_Reader.GetArrayFromJson(Classname, "Invalid_Patient_Detail");
            
            string DupFirstName = json[0]["Duplicate_First_Name"].ToString();
            string DupsurName = json[1]["Duplicate_last_Name"].ToString();
            string InvalidcellNumber = json[2]["Invalid_CellPhoneNumber"].ToString();
            string InvalidemailAddress = json[3]["Invalid_Email_address"].ToString();
            string Invalidpassword = json[4]["Invalidpassword"].ToString();
            string InvalidconfirmPw = json[5]["Invalid_confirm_password"].ToString();
            string InvalidCellPhError = json[6]["InvalidCellPhoneError"].ToString();
            string InvalidEmailError = json[7]["InvalidEmailError"].ToString();
            string InvalidPassError = json[8]["InvalidPassError"].ToString();
           

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Validate the homepage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Login Page and Validate the Login page ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Register page invalid input validation");
            Login_Page.Navigate_To_RegisterPage();
            Register_Page.Validate_RegisterPage();
            Register_Page.Patient_Registration(DupFirstName, DupsurName, InvalidcellNumber, InvalidemailAddress, Invalidpassword, InvalidconfirmPw);
            Register_Page.Patient_Invalid_Detail_Validation(InvalidCellPhError, InvalidEmailError, InvalidPassError);
        }

        public static void VerifyValidationMessageForAllRequiredFieldWhenNoInput()
        {
            var json = Json_Reader.GetArrayFromJson(Classname, "Validation_Message");
            var jsonInv = Json_Reader.GetArrayFromJson(Classname, "Invalid_Patient_Detail");
           
            string FnameReqMessage = json[0]["FnameReqValiMessage"].ToString();
            string SuNameReqMessage = json[1]["SurNameReqMessage"].ToString();
            string ReqValidCellNumber = jsonInv[6]["InvalidCellPhoneError"].ToString();
            string ReqValidEmailAddress = jsonInv[7]["InvalidEmailError"].ToString();
            string ReqPasswordMessage = json[2]["ReqPassErrorMessage"].ToString();
            string ReqConfPasswMessage = json[3]["ReqConfPassMessage"].ToString();
            string TermsAndCondMessage = json[4]["TermsAndContionMessage"].ToString();
           
            Reports.childLog = Reports.CreateNode("Step 1: Navigate to Register Page and Varify Validation messages");
            
            Register_Page.Patient_Form_fill_with_No_input_validation_message(FnameReqMessage, SuNameReqMessage, ReqValidCellNumber, ReqValidEmailAddress, ReqPasswordMessage, ReqConfPasswMessage, TermsAndCondMessage);
        }

    }
}
