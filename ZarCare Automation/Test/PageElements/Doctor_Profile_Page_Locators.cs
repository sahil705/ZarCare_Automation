namespace ZarCare_Automation.Test.PageElements
{
    public class Doctor_Profile_Page_Locators : WebdriverSession
    {
        public By By_ProfileHeader = By.XPath("//div[@class='widget about-widget']/h4");
        public IWebElement Web_ProfileHeader => driver.FindElement(By_ProfileHeader);

        public By By_BookingDateHeader_CurrentDate = By.XPath("//div[@class='owl-item active current']/div/h4");
        public IWebElement Web_BookingDateHeader_CurrentDate => driver.FindElement(By_BookingDateHeader_CurrentDate);

        public By By_BookingDateHeader_NextDate = By.XPath("//div[@class='owl-item current active']/div/h4");
        public IWebElement Web_BookingDateHeader_NextDate => driver.FindElement(By_BookingDateHeader_NextDate);

        public By By_BookingDate_ForwardButton = By.XPath("//button[@class='owl-next']/span");
        public IWebElement Web_BookingDate_ForwardButton => driver.FindElement(By_BookingDate_ForwardButton);

        public By By_BookingSlot_Currentday = By.XPath("//div[@class='owl-item active'] //div[@class='c-day-session-slot-blue']");
        public IList<IWebElement> Web_BookingSlot_Currentday => driver.FindElements(By_BookingSlot_Currentday);

        public By By_EditSlotTimeButton = By.XPath("//a[@class='edit_slot_timing']");

        public IWebElement Web_EditSlotTimeBtn=>driver.FindElement(By_EditSlotTimeButton);

        public By By_EditSlotPage_cancelPolicyText = By.XPath("//h6[@class='text-center mt-4']");

        public IWebElement Web_EditSlotPage_CancelPolicyText=>driver.FindElement(By_EditSlotPage_cancelPolicyText);

        public By By_EditSlotPageAvilableSlot = By.ClassName("li-time");

        public IList<IWebElement> Web_EditSlotPageAvailableSlot=>driver.FindElements(By_EditSlotPageAvilableSlot);

        public By By_EditSlotPageSubmitBtn = By.XPath("//*[contains(text(), ' Continue ')]");

        public IWebElement Web_EditSlotPageSubmitBtn=>driver.FindElement(By_EditSlotPageSubmitBtn);

        public By By_SymtomsDropDownArrow = By.XPath("//button[@title='Select']");

        public IWebElement Web_SymtomsDropDownArrow => driver.FindElement(By_SymtomsDropDownArrow);

        public By By_SymtomsList = By.XPath("//li//a//label[@class='checkbox']");

        public IList<IWebElement> Web_SymtomsList =>driver.FindElements(By_SymtomsList);

        public By By_SymtomsCheckBox = By.XPath("//li//a//label//input[@type='checkbox']");

        public IList<IWebElement>  Web_SymtomsCheckBoxes=>driver.FindElements(By_SymtomsCheckBox);

        public By By_GoToPayBtn = By.XPath("//button[@id='btn-go-to-pay']");

        public IWebElement Web_GotoPayBtn=>driver.FindElement(By_GoToPayBtn);

        public By By_CancelPaymentMessage = By.XPath("//span[@id='spnCancelPayment']");

        public IWebElement Web_CancelPaymentMessage=>driver.FindElement(By_CancelPaymentMessage);

        public By By_SelectedSlotTime = By.XPath("//*[@id='spnEditSlot']/label[2]/span");

        public IWebElement Web_SelectedSlotTime=>driver.FindElement(By_SelectedSlotTime);
    }
}
