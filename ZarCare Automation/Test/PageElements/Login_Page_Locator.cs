namespace ZarCare_Automation.Test.PageElements
{
    public class Login_Page_Locator:WebdriverSession
    {
        public By By_Register_New_Account_Text = By.XPath("//p[@class='small']//a");
        public IWebElement Web_Register_New_Account_Text => driver.FindElement(By_Register_New_Account_Text);

        public By By_Forgot_Password_Link = By.XPath("//a[@id='forgotPassword']");
        public IWebElement Web_Forgot_Password_Link => driver.FindElement(By_Forgot_Password_Link);

        public By By_Login_Page_Text = By.CssSelector("h2[aria-level='1']");
        public IWebElement Web_Login_Page_Text => driver.FindElement(By_Login_Page_Text);

        public By By_Email_TextBox = By.Id("email");
        public IWebElement Web_Email_TextBox => driver.FindElement(By_Email_TextBox);

        public By By_Password_TextBox = By.Id("password");
        public IWebElement Web_Password_TextBox => driver.FindElement(By_Password_TextBox);
        
        public By By_SignIn_Button = By.XPath("//button[@id='next']");
        public IWebElement Web_SignIn_Button => driver.FindElement(By_SignIn_Button);

        public By By_Invalid_Email_Text = By.CssSelector("div[aria-hidden='false'] p");
        public IWebElement Web_Invalid_Email_Text => driver.FindElement(By_Invalid_Email_Text);

        public By By_Incorrect_Password_Text = By.CssSelector("div[class='error pageLevel'] p");
        public IWebElement Web_Incorrect_Password_Text => driver.FindElement(By_Incorrect_Password_Text);

        public By By_Unregistered_Error_Text = By.CssSelector("div[class='error pageLevel'] p");
        public IWebElement Web_Unregistered_Error_Text => driver.FindElement(By_Unregistered_Error_Text);

        public By By_Required_Email = By.CssSelector("div[class='entry-item'] div[role='alert'] p");
        public IWebElement Web_Required_Email => driver.FindElement(By_Required_Email);

        public By By_Required_Password = By.CssSelector("p[role='alert']");
        public IWebElement Web_Required_Password => driver.FindElement(By_Required_Password);

        public By By_Zarcare_Logo = By.CssSelector(".text-center.m-b-30 a");
        public IWebElement Web_Zarcare_Logo =>driver.FindElement(By_Zarcare_Logo);
    
    }
}
