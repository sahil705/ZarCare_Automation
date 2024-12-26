using WebDriverManager.Clients;

namespace TestScripts
{
    public class Register : Base
    {
       

        [Test]
        public void Patient_Registration()
        {
            Reports.childLog = Reports.CreateNode("Submit the Patient Registration Form ");
            RegisterPageValidation.Enter_Patient_Detaill_On_Registration_Page();
            Reports.FlushNode(Reports.childLog);
           
        }
        [Test]

        public void RedirectTo_OTP_pageAfterRegistrationDetail()
        {
            Reports.childLog = Reports.CreateNode("Redirect to OTP page after Registration Detail");
            RegisterPageValidation.VerifyMemeberRedirectTo_OTP_pageAfterRegistrationDetail();
            Reports.FlushNode(Reports.childLog);

        }
        [Test]

        public void ValidationMessageWithInvalidRegistrationFormDetail()
        {
            Reports.childLog = Reports.CreateNode("Validation message after Invalid registeration form detail");
            RegisterPageValidation.VerifyValidationMessageWithInvalidRegistrationFormDetail();
            Reports.FlushNode(Reports.childLog);

        }

        [Test]

        public void ValidationMessageForAllRequiredFieldWhenNoInput()
        {
            Reports.childLog = Reports.CreateNode("Validation message when no input in required registeration fileld");
            RegisterPageValidation.VerifyValidationMessageForAllRequiredFieldWhenNoInput();
            Reports.FlushNode(Reports.childLog);
        }
    }
}
