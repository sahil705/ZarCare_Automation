
namespace ZarCare_Automation.Test.PageActions
{
    public class Register_Page:WebdriverSession
    {
        public static Register_Page_Locator RegisterPage = new Register_Page_Locator(); 

        public static void Validate_RegisterPage()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(RegisterPage.By_RegisterPageElement);

            Reports.childLog.Log(Status.Info, "Register page is displayed");
            Generic_Utils.GetScreenshot("Register page screenshot ");
        }

        public static void Patient_Registration(string firstName,string surName,string cellPhoneNumber,string emailAddress, string password,string confirmPassword)
        {
            RegisterPage.Web_FirstName.SendKeys(firstName);
            RegisterPage.Web_SurName.SendKeys(surName); 
            RegisterPage.Web_CellPhoneNumber.SendKeys(cellPhoneNumber);
            RegisterPage.Web_EmailAddress.SendKeys(emailAddress);
            RegisterPage.Web_Password.SendKeys(password);   
            RegisterPage.Web_ConfirmPassword.SendKeys(confirmPassword); 
            RegisterPage.Web_Term_of_Use.Click();   
            RegisterPage.Web_Medical_Health_WellBeing.Click();  
            RegisterPage.Web_Marketing_Communication.Click();   
            RegisterPage.Web_RegisterButton.Click();    
        }

        public static void Patient_Invalid_Detail_Validation(string InvalidCellPhError, string InvalidEmailError, string InvalidPassError)
        {
            string InvCellPhoneErrorText= RegisterPage.Web_InvalidCellPhone.Text;
            Assert.That(InvCellPhoneErrorText, Is.EqualTo(InvalidCellPhError));

            string InvEmailErrorText=RegisterPage.Web_InvalidEmailError.Text;
            Assert.That(InvEmailErrorText, Is.EqualTo(InvalidEmailError));

            string InvaPassErrorText = RegisterPage.Web_InvalidPasswordError.Text;
            Assert.That(InvaPassErrorText, Is.EqualTo(InvalidPassError));

            Reports.childLog.Log(Status.Info, "Invalid Detail validation message displayed");
            Generic_Utils.GetScreenshot("Invalid Detail Validation messages screenshot ");

        }
        public static void Patient_Form_fill_with_No_input_validation_message(string FnameRequiredMessage,string SuNameRequiredMessage,string RequiredValidCellPhoneNumber,string RequiredValidEmailAddress,string RequiredPasswordErrorMessage,string RequiredConfPasswErrorMessage,string TermsAndCondErrorMessage)
        {
            driver.Navigate().Refresh();
            RegisterPage.Web_RegisterButton.Click();

            string FnameValidationMessageText= RegisterPage.Web_FnameReqMessage.Text;
            Assert.That(FnameValidationMessageText, Is.EqualTo(FnameRequiredMessage));

            string SurNameValidationMessageText=RegisterPage.Web_SurNameReMessage.Text;
            Assert.That(SurNameValidationMessageText, Is.EqualTo(SuNameRequiredMessage));

            string ValidationCellPhonetext = RegisterPage.Web_CellPhoneReqMessage.Text;
            Assert.That(ValidationCellPhonetext, Is.EqualTo(RequiredValidCellPhoneNumber));

            string EmailValidMessageText=RegisterPage.Web_InvalidEmailError.Text;
            Assert.That(EmailValidMessageText, Is.EqualTo(RequiredValidEmailAddress));

            string RequiredPasswordValidationMessage= RegisterPage.Web_InvalidPasswordError.Text;
            Assert.That(RequiredPasswordValidationMessage, Is.EqualTo(RequiredPasswordErrorMessage));

            string RequiredConfPasserrorMessage=RegisterPage.Web_ConfPassReqMessage.Text;
            Assert.That(RequiredConfPasserrorMessage, Is.EqualTo(RequiredConfPasswErrorMessage));

            string TermsAndConditiontext=RegisterPage.Web_TermsAndConditionMessage.Text;
            Assert.That(TermsAndConditiontext, Is.EqualTo(TermsAndCondErrorMessage));

            Reports.childLog.Log(Status.Info, "Required input validation message displayed");
            Generic_Utils.GetScreenshot("Validation messages screenshot ");


        }
    }
}
