namespace ZarCare_Automation.Test.PageElements
{
    public class WorkWithUs_Locators:WebdriverSession
    {
        public By By_WorkWithUs_Page_Element = By.XPath("//div[@class='heading']/h1");
        public IWebElement Web_WorkWithUs_Page_Element => driver.FindElement(By_WorkWithUs_Page_Element);

        public By By_First_Name = By.Id("txtFName");
        public IWebElement Web_First_Name =>driver.FindElement(By_First_Name);

        public By By_Sur_Name = By.Id("txtSName");
        public IWebElement Web_Sur_Name => driver.FindElement(By_Sur_Name);

        public By By_CellPhone_Number = By.Id("txtContactNo");
        public IWebElement Web_CellPhone_Number => driver.FindElement(By_CellPhone_Number);

        public By By_Email = By.Id("txtEmail");
        public IWebElement Web_Email => driver.FindElement(By_Email);

        public By By_Profession_Dropdown = By.CssSelector("#drpspecialization");
        public IWebElement Web_Profession_Dropdown => driver.FindElement(By_Profession_Dropdown);

        public By By_Province_Dropdown = By.Id("ddProvince");
        public IWebElement Web_Province_Dropdown => driver.FindElement(By_Province_Dropdown);

        public By By_City = By.Id("txtCity");
        public IWebElement Web_City => driver.FindElement(By_City);

        public By By_Service_Dropdown = By.CssSelector("#txtCurrentP");
        public IWebElement Web_Service_Dropdown => driver.FindElement(By_Service_Dropdown);

        public By By_Submit_Button = By.Id("btnSubmit");
        public IWebElement Web_Submit_Button => driver.FindElement(By_Submit_Button);

        public By By_Confirmation_Popup = By.XPath("//div[@class='modal-content']");
        public IWebElement Web_Confirmation_Popup => driver.FindElement(By_Confirmation_Popup);

        public By By_Confirmation_Popup_Close_Icon = By.CssSelector("//span[air-hidden='true']");
        public IWebElement Web_Confirmation_Popup_Close_Icon => driver.FindElement(By_Confirmation_Popup_Close_Icon);

        





    }
}
