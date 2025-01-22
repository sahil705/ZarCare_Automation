
namespace ZarCare_Automation.Test.PageActions
{
    public class Login_Page:WebdriverSession
    {
        public static Login_Page_Locator LoginPage = new Login_Page_Locator();  

        public static void Validate_LoginPage() 
        {
            Generic_Utils.WindowHandle();
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(LoginPage.By_Login_Page_Text);

            Reports.childLog.Log(Status.Info, "Login page is displayed");
            Generic_Utils.GetScreenshot("Login page screenshot ");
        }

        public static void Navigate_To_RegisterPage ()
        {
            LoginPage.Web_Register_New_Account_Text.Click();
        }

        public static void Navigate_To_Forgot_PasswordPage()
        {
            LoginPage.Web_Forgot_Password_Link.Click(); 
        }

        public static void Navigate_To_HomePage()
        {
            LoginPage.Web_Zarcare_Logo.Click(); 
        }
        public static void Patient_Login(string email, string password)
        {
            Generic_Utils.ClearTextBox(LoginPage.Web_Email_TextBox);
            LoginPage.Web_Email_TextBox.SendKeys(email);
            Generic_Utils.ClearTextBox(LoginPage.Web_Password_TextBox);
            LoginPage.Web_Password_TextBox.SendKeys(password);
            LoginPage.Web_SignIn_Button.Click();
 
        }
        public static bool Get_EmailAndCellPhone_Status(string email, string cell)
        {
            bool status = Database_Utils.getEmailAndCellVerificationStatus(email, cell);
            return status;
        }
        public static void Validate_Invalid_Email_Message(string invalidEmailText)
        {
            
            Wait.ElementIsVisible(LoginPage.By_Invalid_Email_Text, 5);
            string getText =  Generic_Utils.getText(LoginPage.Web_Invalid_Email_Text);
            Assert.That(getText, Is.EqualTo(invalidEmailText));

            Reports.childLog.Log(Status.Info, "Email Validation Message displayed");
            Generic_Utils.GetScreenshot("Email Validation Message Screenshot ");
        }
      

        public static void Validate_Incorrect_Password_Message(string invalidPasswordText)
        {
            Wait.ElementIsVisible(LoginPage.By_Incorrect_Password_Text, 5);
            string getText = Generic_Utils.getText(LoginPage.Web_Incorrect_Password_Text); 
            Assert.That(getText, Is.EqualTo(invalidPasswordText));

            Reports.childLog.Log(Status.Info, "Password Validation Message displayed");
            Generic_Utils.GetScreenshot("Password Validation Message Screenshot ");
        }

        public static void Validate_Unregistered_Error_Message(string unregisteredErrorText)
        {
            Wait.ElementIsVisible(LoginPage.By_Unregistered_Error_Text, 5);
            string getText = Generic_Utils.getText(LoginPage.Web_Unregistered_Error_Text); 
            Assert.That(getText,Is.EqualTo(unregisteredErrorText));

            Reports.childLog.Log(Status.Info, "Account Validation Message displayed");
            Generic_Utils.GetScreenshot("Account Validation Message Screenshot ");
        }

        public static void Validate_Required_Login_Fields(string email, string password)
        {
            Wait.ElementIsVisible(LoginPage.By_Required_Email, 5);
            string getEmail = Generic_Utils.getText(LoginPage.Web_Required_Email);
            Wait.ElementIsVisible(LoginPage.By_Required_Password, 5);
            string getPassword = Generic_Utils.getText(LoginPage.Web_Required_Password);

            Assert.Multiple(() =>
            {
                Assert.That(getEmail, Is.EqualTo(email));   
                Assert.That(getPassword, Is.EqualTo(password)); 
            });

            Reports.childLog.Log(Status.Info, "Required Validation Message displayed");
            Generic_Utils.GetScreenshot("Required Validation Message Screenshot ");
        }

    }
}
