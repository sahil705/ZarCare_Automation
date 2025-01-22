namespace ZarCare_Automation.Test.PageElements
{
    public class Forgot_Password_Locator:WebdriverSession
    {
        public By By_Forgot_Password_Header = By.Id("emailVerificationControl_but_send_code");
        public IWebElement Web_Forgot_Password_Header => driver.FindElement(By_Forgot_Password_Header);

        public By By_Back_To_Login = By.XPath("(//p[@class='small'] /a)[1]");
        public IWebElement Web_Back_To_Login => driver.FindElement(By_Back_To_Login);

    }
}
