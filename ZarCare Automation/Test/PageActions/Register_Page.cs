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

        public static void Patient_Registration(string firstName,string surName,string cellNumber,string emailAddress, string password,string confirmPassword)
        {
            RegisterPage.Web_FirstName.SendKeys(firstName);
            RegisterPage.Web_SurName.SendKeys(surName); 
            RegisterPage.Web_CellPhoneNumber.SendKeys(cellNumber);
            RegisterPage.Web_EmailAddress.SendKeys(emailAddress);
            RegisterPage.Web_Password.SendKeys(password);   
            RegisterPage.Web_ConfirmPassword.SendKeys(confirmPassword); 
            RegisterPage.Web_Term_of_Use.Click();   
            RegisterPage.Web_Medical_Health_WellBeing.Click();  
            RegisterPage.Web_Marketing_Communication.Click();   
            RegisterPage.Web_RegisterButton.Click();    
        }

    }
}
