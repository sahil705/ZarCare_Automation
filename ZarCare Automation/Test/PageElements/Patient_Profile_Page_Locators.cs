namespace ZarCare_Automation.Test.PageElements
{
    public class Patient_Profile_Page_Locators:WebdriverSession
    {
        public By By_FirstName_Textbox = By.Id("txtFirstName");
        public IWebElement Web_FirstName_Textbox => driver.FindElement(By_FirstName_Textbox);

        public By By_LastName_Textbox = By.Id("txtLastName");
        public IWebElement Web_LastName_Textbox => driver.FindElement(By_LastName_Textbox);

        public By By_Weight_Textbox = By.XPath("//input[@id='txtWeight']");
        public IWebElement Web_Weight_Textbox => driver.FindElement(By_Weight_Textbox);

        public By By_Height_Textbox = By.XPath("//input[@id='txtHeight']");
        public IWebElement Web_Height_Textbox => driver.FindElement(By_Height_Textbox);

        public By By_Gender_Dropdown = By.Id("drpGender");
        public IWebElement Web_Gender_Dropdown => driver.FindElement(By_Gender_Dropdown);

        public By By_Address_Textbox = By.Id("txtAddress");
        public IWebElement Web_Address_Textbox => driver.FindElement(By_Address_Textbox);

        public By By_SubUrb_Textbox = By.Name("Suburb");
        public IWebElement Web_SubUrb_Textbox => driver.FindElement(By_SubUrb_Textbox);

        public By By_City_Textbox = By.Id("txtCity");
        public IWebElement Web_City_Textbox => driver.FindElement(By_City_Textbox);

        public By By_Province_Textbox = By.Id("txtState");
        public IWebElement Web_Province_Textbox => driver.FindElement(By_Province_Textbox);

        public By By_PostalCode_Textbox = By.Id("txtPincode");
        public IWebElement Web_PostalCode_Textbox => driver.FindElement(By_PostalCode_Textbox);

        public By By_Submit_Button = By.XPath("//div[@class='text-center mt-3']/button");
        public IWebElement Web_Submit_Button => driver.FindElement(By_Submit_Button);

        public By By_ProfilePicture_Text = By.XPath("//div[@class='make_visible']/label");
        public IWebElement Web_ProfilePicture_Text => driver.FindElement(By_ProfilePicture_Text);

        public By By_Success_Message = By.CssSelector("#message");
        public IWebElement Web_Success_Message => driver.FindElement(By_Success_Message);

        public By By_LeftMenu_Dashboard_Link = By.CssSelector("li[id='liDashboard'] a");
        public IWebElement Web_LeftMenu_Dashboard_Link => driver.FindElement(By_LeftMenu_Dashboard_Link);
    }
}

