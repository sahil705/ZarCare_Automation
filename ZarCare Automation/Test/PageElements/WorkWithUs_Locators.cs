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

        public By By_Confirmation_Popup_Close_Icon = By.Id("popUpClosemodalbtn");
        public IWebElement Web_Confirmation_Popup_Close_Icon => driver.FindElement(By_Confirmation_Popup_Close_Icon);

        public By By_Work_With_Us_Success_Message_Text = By.XPath("//div[@class='modal-content']//span[@id='spnConfirmSuccess']");
        public IWebElement Web_Work_With_Us_Success_Message_Text => driver.FindElement(By_Work_With_Us_Success_Message_Text);

        public By By_FirstName_Validation = By.XPath("//span[@id='firstNameError']");
        public IWebElement Web_FirstName_Validation => driver.FindElement(By_FirstName_Validation);

        public By By_SurName_Validation = By.XPath("//span[@id='lastNameError']");
        public IWebElement Web_SurName_Validation => driver.FindElement(By_SurName_Validation);

        public By By_CellPhone_Validation = By.XPath("//span[@id='phoneNoError']");
        public IWebElement Web_CellPhone_Validation => driver.FindElement(By_CellPhone_Validation);

        public By By_Email_Validation = By.XPath("//span[@id='emailError']");
        public IWebElement Web_Email_Validation => driver.FindElement(By_Email_Validation);

        public By By_Profession_Validation = By.XPath("//span[@id='drpspecializationError']");
        public IWebElement Web_Profession_Validation => driver.FindElement(By_Profession_Validation);

        public By By_Province_Validation = By.XPath("//span[@id='provinceError']");
        public IWebElement Web_Province_Validation => driver.FindElement(By_Province_Validation);

        public By By_City_Validation = By.XPath("//span[@id='cityError']");
        public IWebElement Web_City_Validation => driver.FindElement(By_City_Validation);

        public By By_Current_WorkPlace_Validation = By.XPath("//span[@id='CurrentWorkPlaceError']");
        public IWebElement Web_Current_WorkPlace_Validation => driver.FindElement(By_Current_WorkPlace_Validation);

        public By By_WorkWithUs_Error_Message = By.XPath("//span[@id='emailcheckerror']");
        public IWebElement Web_WorkWithUs_Error_Message => driver.FindElement(By_WorkWithUs_Error_Message);


    }
}
