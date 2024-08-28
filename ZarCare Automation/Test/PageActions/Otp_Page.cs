using TestScripts;

namespace ZarCare_Automation.Test.PageActions
{
    public class Otp_Page:WebdriverSession
    {
        public static Otp_Page_Locator OtpPage = new Otp_Page_Locator();

        public static void Validate_Otp_Page()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(OtpPage.By_Otp_Page_Element_Text);

            Reports.childLog.Log(Status.Info, "Otp page is displayed");
            Generic_Utils.GetScreenshot("Otp page screenshot");
        }

        public static void Enter_and_Submit_Otp()
        {
            string Capture_Otp = Database_Utils.Get_OTP_From_Database();
            for (int i = 0; i < Capture_Otp.Length; i++)
            {
                IWebElement otpField =OtpPage.GetOtpField(i);
                otpField.SendKeys(Capture_Otp[i].ToString());
            }
            OtpPage.Web_Submit_Otp_Button.Click();
        }
    }
}
