namespace ZarCare_Automation.Test.PageElements
{
    public class Login_Page_Locator:WebdriverSession
    {
        public By By_Register_New_Account_Text = By.XPath("//p[@class='small']//a");
        public IWebElement Web_Register_New_Account_Text => driver.FindElement(By_Register_New_Account_Text);

        public By By_Login_Page_Text = By.CssSelector("h2[aria-level='1']");
        public IWebElement Web_Login_Page_Text => driver.FindElement(By_Login_Page_Text);

        public By By_Email_TextBox = By.Id("email");
        public IWebElement Web_Email_TextBox => driver.FindElement(By_Email_TextBox);

        public By By_Password_TextBox = By.Id("password");
        public IWebElement Web_Password_TextBox => driver.FindElement(By_Password_TextBox);
        
        public By By_SignIn_Button = By.XPath("//button[@id='next']");
        public IWebElement Web_SignIn_Button => driver.FindElement(By_SignIn_Button);
    }
}
