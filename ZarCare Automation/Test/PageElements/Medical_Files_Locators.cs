namespace ZarCare_Automation.Test.PageElements
{
    public class Medical_Files_Locators : WebdriverSession
    {
        public By By_MedicalFile_Header = By.XPath("//div[@class='col-md-9']");
        public IWebElement Web_MedicalFile_Header => driver.FindElement(By_MedicalFile_Header);

        public By By_PatientName = By.XPath("//div[@class='profile-det-info text-left']/h3[1]");
        public IWebElement Web_Patient_Name => driver.FindElement(By_PatientName);

        public By By_MedicalFile_Cards = By.CssSelector(".card-body");
        public IList<IWebElement> Web_MedicalFile_Cards => driver.FindElements(By_MedicalFile_Cards);

        public By By_MedicalFile_Name = By.XPath(".//div[@class='profile-det-info text-left'] //h3");
        
        public By By_MedicalFile_Status = By.XPath(".//div[@class='patient-info']//li[contains(text(), 'Medical File Status')]/span");
        

    }
}
