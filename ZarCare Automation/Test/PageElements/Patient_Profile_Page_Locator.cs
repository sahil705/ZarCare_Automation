namespace ZarCare_Automation.Test.PageElements
{
    public class Patient_Profile_Page_Locator:WebdriverSession
    {
        public By By_Patient_Profile_Confirmation_Text = By.XPath("//span[@style='text-transform:capitalize;']");
        public IWebElement Web_Patient_Profile_Confirmation_Text => driver.FindElement(By_Patient_Profile_Confirmation_Text);

        public By By_Find_Provider_Link = By.CssSelector("#liFindDoctor");
        public IWebElement Web_Find_Provider_Link => driver.FindElement(By_Find_Provider_Link);

        public By By_Active_Appointment_View_All_Link = By.XPath("(//div[@class = 'card mb-4']//h4[@class='card-title']/a)[2]");
        public IWebElement Web_Active_Appointment_View_All_Link => driver.FindElement(By_Active_Appointment_View_All_Link);








    }

}
