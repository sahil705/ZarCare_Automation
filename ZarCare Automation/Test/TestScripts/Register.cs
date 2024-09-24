namespace TestScripts
{
    public class Register:Base
    {
        public string classname = "Register";

        [Test]
        public void Patient_Registration()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string firstName = json["First_Name"].ToString();
            string surName = json["Sur_Name"].ToString();
            string cellNumber = json["CellPhone_Number"].ToString();
            string emailAddress = json["Email_Address"].ToString();
            string password = json["Pass_Word"].ToString();
            string confirmPassword = json["Confirm_Password"].ToString();

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
            Register_Page.Patient_Registration(firstName,surName, cellNumber, emailAddress,password, confirmPassword);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Navigate to OTP Page and Submit the Otp");
            Otp_Page.Validate_Otp_Page();   
            Otp_Page.Enter_and_Submit_Otp();
            Login_Page.Validate_LoginPage();
            Reports.FlushNode(Reports.childLog);
        }
    
    
    
    }
}
