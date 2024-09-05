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




    }
}
