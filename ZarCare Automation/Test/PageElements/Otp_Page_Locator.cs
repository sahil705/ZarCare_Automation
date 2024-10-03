namespace ZarCare_Automation.Test.PageElements
{
    public class Otp_Page_Locator : WebdriverSession
    {
        public By By_Otp_Page_Element_Text = By.CssSelector(".p-text.mb-0");
        public IWebElement Web_Otp_Page_Element_Text => driver.FindElement(By_Otp_Page_Element_Text);

        public By By_Submit_Otp_Button = By.CssSelector("button[type='submit']");
        public IWebElement Web_Submit_Otp_Button =>driver.FindElement(By_Submit_Otp_Button);    

        //Creating a dynamic xpath
        public By GetOtpFieldLocator(int index)
        {
            return By.XPath($"//*[@id='digit-{index + 1}']");
        }
        
        public IWebElement GetOtpField(int index)
        {
            By otpFieldLocator = GetOtpFieldLocator(index);
            return driver.FindElement(otpFieldLocator);
        }
    }
}