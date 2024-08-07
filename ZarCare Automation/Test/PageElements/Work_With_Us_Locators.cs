namespace ZarCare_Automation.Test.PageElements
{
    public class Work_With_Us_Locators : WebdriverSession
    {
        public By By_Work_With_Us_Text = By.XPath("//div[@class='heading']/h1");
        public IWebElement Web_Work_With_Us_Text => driver.FindElement(By_Work_With_Us_Text);

        public By By_Submit_Button = By.Id("//*[@id='btnSubmit']");
        public IWebElement Web_Submit_Button => driver.FindElement(By_Submit_Button);

        public By By_FirstName_Textbox = By.Id("//input[@id='txtFName']");
        public IWebElement Web_FirstName_Textbox => driver.FindElement(By_FirstName_Textbox);

        public By By_SurName_Textbox = By.Id("//input[@id='txtSName']");
        public IWebElement Web_SurName_Textbox => driver.FindElement(By_SurName_Textbox);

        public By By_ContactNo_Textbox = By.Id("//input[@id='txtContactNo']");
        public IWebElement Web_ContactNo_Textbox => driver.FindElement(By_ContactNo_Textbox);

        public By By_Email_Textbox = By.Id("//input[@id='txtEmail']");
        public IWebElement Web_Email_Textbox => driver.FindElement(By_Email_Textbox);

        public By By_Profession_List = By.XPath("//select[@id='drpspecialization']");
        public IWebElement Web_Profession_List => driver.FindElement(By_Profession_List);

        public By By_Province_List = By.Id("//select[@id='ddProvince']");
        public IWebElement Web_Province_List => driver.FindElement(By_Province_List);

        public By By_City_Textbox = By.Id("//input[@id='txtCity']");
        public IWebElement Web_City_Textbox => driver.FindElement(By_City_Textbox);

        public By By_WorkPlace_List = By.Id("//select[@id='txtCurrentP']");
        public IWebElement Web_WorkPlace_List => driver.FindElement(By_WorkPlace_List);
    }
}
