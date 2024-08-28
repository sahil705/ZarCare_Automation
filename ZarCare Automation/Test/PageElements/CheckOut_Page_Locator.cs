namespace ZarCare_Automation.Test.PageElements
{
    public class CheckOut_Page_Locator:WebdriverSession
    {
        public By By_CheckOut_Page_Header = By.XPath("h4[@class='title_heading m-0 border-bottom pb-2'])[1]");
        public IWebElement Web_CheckOut_Page_Header => driver.FindElement(By_CheckOut_Page_Header);

        public By By_Voucher_TextBox = By.Id("txtVoucherCode");
        public IWebElement Web_Voucher_TextBox => driver.FindElement(By_Voucher_TextBox);

        public By By_Voucher_Apply_Button = By.Id("btnApplyVoucher");
        public IWebElement Web_Voucher_Apply_Button => driver.FindElement(By_Voucher_Apply_Button);

        public By By_Voucher_Success_Message = By.CssSelector(".msg-hld.mt-2");
        public IWebElement Web_Voucher_Success_Message => driver.FindElement(By_Voucher_Success_Message);

        public By By_Voucher_Consent_Checkbox = By.Id("chkConsent");
        public IWebElement Web_Voucher_Consent_Checkbox => driver.FindElement(By_Voucher_Consent_Checkbox);

        public By By_Symptoms_Dropdown = By.XPath("//div[@class='btn-group']/button");
        public IWebElement Web_Symptoms_Dropdown => driver.FindElement(By_Symptoms_Dropdown);

        public By By_Symptoms_Name = By.CssSelector("input[value='Anxiety']");
        public IWebElement Web_Symptoms_Name =>driver.FindElement(By_Symptoms_Name);

        public By By_Public_Checkout_Symptoms_Name = By.CssSelector("input[value='Anxiet']");
        public IWebElement Web_Public_Checkout_Symptoms_Name => driver.FindElement(By_Public_Checkout_Symptoms_Name);

        public By By_Continue_Payment_Button = By.XPath("//div[@class='mt-3 continue_button']/button");
        public IWebElement Web_Continue_Payment_Button => driver.FindElement(By_Continue_Payment_Button);



    }
}
