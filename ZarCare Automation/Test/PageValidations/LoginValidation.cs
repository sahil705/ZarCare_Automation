namespace ZarCare_Automation.Test.PageValidations
{
    public class LoginValidation
    {
        public static string Login = "LoginData";

        public static void ValidateUserLoginWithValidData()
        {
            var loginJson = Json_Reader.GetArrayFromJson(Login, "ValidLoginData");
            string userEmail = loginJson[0]["Login_Patient_Email"].ToString();
            string userPassword = loginJson[0]["Login_Patient_Password"].ToString();
            string userCell = loginJson[0]["Patient_CellPhone"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Login Form Submission ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Login as a Patient with Valid Data ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(userEmail, userPassword);

            Reports.childLog.Log(Status.Info, "Step 3: Check the Email and Cellphone Status ");
            bool status = Login_Page.Get_EmailAndCellPhone_Status(userEmail,userCell);
            if (status == true)
            {
                Reports.childLog.Log(Status.Info, "Step 4: Validate the Patient Dashboard ");
                Patient_Dashboard_Page.ValidatePatientDashboard();
                Patient_Dashboard_Page.userLogout();
            }
            else
            {
                Reports.childLog.Log(Status.Info, "Step 4: Redirects to Email and Cellphone Verification Page"); 
                Patient_Dashboard_Page.ValidateUnverifiedDashboard();
                Patient_Dashboard_Page.userLogout();
            }

 
            Reports.childLog.Log(Status.Info, "=================================================");

        }

        public static void ValidateUserLoginWithInvalidData()
        {
            var loginJson = Json_Reader.GetArrayFromJson(Login, "LoginInvalidData");
            var login = Json_Reader.GetArrayFromJson(Login, "UnregisteredUser");
            var loginRequired = Json_Reader.GetArrayFromJson(Login, "RequiredData");
            var loginMessage = Json_Reader.GetArrayFromJson(Login, "errorMessages");
            string userEmailSet1 = loginJson[0]["Login_Invalid_Patient_Email"].ToString();
            string userPasswordSet1 = loginJson[0]["Login_Invalid_Patient_Password"].ToString();
            string userEmailSet2 = loginJson[1]["Login_Invalid_Patient_Email"].ToString();
            string userPasswordSet2 = loginJson[1]["Login_Invalid_Patient_Password"].ToString();
            string userEmailSet3 = login[0]["Login_Unregistered_Email"].ToString();
            string userPasswordSet3 = login[0]["Login_Unregistered_Password"].ToString();
            string invalidEmail = loginMessage[3]["Login_Invalid_Email"].ToString();
            string incorrectPassword = loginMessage[4]["Login_Invalid_Password"].ToString();
            string unregisteredAccount = loginMessage[2]["Login_Unregistered_Error"].ToString();
            string userEmailSet4 = loginRequired[0]["Login_Email"].ToString();
            string userPasswordSet4 = loginRequired[0]["Login_Password"].ToString();
            string requiredEmailMessage = loginMessage[0]["Login_Email_Error"].ToString();
            string requiredPasswordMessage = loginMessage[1]["Login_Password_Error"].ToString();


            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Login Form Submission with Invalid Data Set ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();

            Reports.childLog.Log(Status.Info, "Step 3: Validate the Invalid Datasets in Login Page");
            Login_Page.Patient_Login(userEmailSet1, userPasswordSet1);
            Login_Page.Validate_Invalid_Email_Message(invalidEmail);
            Login_Page.Patient_Login(userEmailSet2, userPasswordSet2);
            Login_Page.Validate_Incorrect_Password_Message(incorrectPassword);
            Login_Page.Patient_Login(userEmailSet3, userPasswordSet3);
            Login_Page.Validate_Unregistered_Error_Message(unregisteredAccount);
            Login_Page.Patient_Login(userEmailSet4, userPasswordSet4);
            Login_Page.Validate_Required_Login_Fields(requiredEmailMessage, requiredPasswordMessage);

            Reports.childLog.Log(Status.Info, "=================================================");

        }

       public static void RedirectionLinksOnLoginPage()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Login Page Links ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();

            Reports.childLog.Log(Status.Info, "Step 3: Validate the ForgotPassword Link  ");
            Login_Page.Navigate_To_Forgot_PasswordPage();
            ForgotPassword_Page.Validate_Forgot_Password_Page();
            ForgotPassword_Page.NavigateToLogin();       

            Reports.childLog.Log(Status.Info, "Step 4: Validate the Register Link  ");
            Login_Page.Navigate_To_RegisterPage();  
            Register_Page.Validate_RegisterPage(); 
            Register_Page.Navigate_To_Login_Page(); 
            
            Reports.childLog.Log(Status.Info, "Step 5: Validate the HomePage Link  ");
            Login_Page.Navigate_To_HomePage();
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "=================================================");

        }

        public static void ValidateUnverifiedEmailAndCell()
        {
            var loginJson = Json_Reader.GetArrayFromJson(Login, "UnverifiedUserEmail");
            string userEmail = loginJson[0]["Unverified_Login_Email"].ToString();
            string userPassword = loginJson[0]["Unverified_Login_Password"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Email and CellPhone Verification ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();

            Reports.childLog.Log(Status.Info, "Step 3: Email and Cellphone Verification");
            Login_Page.Patient_Login(userEmail, userPassword);
            Patient_Dashboard_Page.ValidateUnverifiedDashboard();
        
        }
    }
}