namespace ZarCare_Automation.Test.PageElements
{
    public class Register_Page_Locator:WebdriverSession
    {
        public By By_RegisterPageElement = By.XPath("//h3[@class='font-16']");
        public IWebElement Web_RegisterPageElement => driver.FindElement(By_RegisterPageElement); 

        public By By_FirstName = By.Id("txtFirstName");
        public IWebElement Web_FirstName => driver.FindElement(By_FirstName);

        public By By_SurName = By.Id("txtLastName");
        public IWebElement Web_SurName => driver.FindElement(By_SurName);

        public By By_CellPhoneNumber = By.Id("txtRegisterPhone");
        public IWebElement Web_CellPhoneNumber => driver.FindElement(By_CellPhoneNumber);

        public By By_EmailAddress = By.Id("txtEmail");
        public IWebElement Web_EmailAddress => driver.FindElement(By_EmailAddress);

        public By By_Password = By.Id("password");
        public IWebElement Web_Password => driver.FindElement(By_Password);

        public By By_ConfirmPassword = By.Id("confirmPassword");
        public IWebElement Web_ConfirmPassword => driver.FindElement(By_ConfirmPassword);

        public By By_Term_of_Use = By.Id("chkConsent");
        public IWebElement Web_Term_of_Use => driver.FindElement(By_Term_of_Use);

        public By By_Medical_Health_WellBeing = By.Id("chkConsentMedical");
        public IWebElement Web_Medical_Health_WellBeing => driver.FindElement(By_Medical_Health_WellBeing);

        public By By_Marketing_Communication = By.Id("IsMarketingConsentAccepted");
        public IWebElement Web_Marketing_Communication => driver.FindElement(By_Marketing_Communication);

        public By By_RegisterButton = By.Id("btnSubmit");
        public IWebElement Web_RegisterButton => driver.FindElement(By_RegisterButton);

        public By By_Back_To_Login_Link = By.XPath("(//p[@class='small'] /a)[1]");
        public IWebElement Web_Back_To_Login_Link => driver.FindElement(By_Back_To_Login_Link); 

        //Invalid registration detail error messages

        public By By_InvalidCellPhoneError = By.Id("phoneNoError");

        public IWebElement Web_InvalidCellPhone=>driver.FindElement(By_InvalidCellPhoneError);

        public By By_InvalidEmailError = By.Id("emailError");

        public IWebElement Web_InvalidEmailError=>driver.FindElement(By_InvalidEmailError);

        public By By_InvalidPasswordError = By.Id("newpasswordval");

        public IWebElement Web_InvalidPasswordError => driver.FindElement(By_InvalidPasswordError);

        public By By_InavlidConfPassError = By.Id("confirmpasswordval");

        public IWebElement Web_InvalidConfPassError=>driver.FindElement(By_InavlidConfPassError);

        //No input validation error message

        public By by_FnameReqMessage = By.Id("firstNameError");

        public IWebElement Web_FnameReqMessage => driver.FindElement(by_FnameReqMessage);

        public By by_SurNameReqMessage = By.Id("lastNameError");

         public IWebElement Web_SurNameReMessage => driver.FindElement(by_SurNameReqMessage);

        public By by_CellPhoneReqMessage = By.Id("phoneNoError");

        public IWebElement Web_CellPhoneReqMessage => driver.FindElement(by_CellPhoneReqMessage);

        public By by_ConfPassRegMessage = By.Id("confirmpasswordval");

        public IWebElement Web_ConfPassReqMessage => driver.FindElement(by_ConfPassRegMessage);

        public By by_TermsAndconditionMessage = By.Id("spnMessageConsent");

        public IWebElement Web_TermsAndConditionMessage => driver.FindElement(by_TermsAndconditionMessage);



    }
}
