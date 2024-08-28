namespace ZarCare_Automation.Test.PageElements
{
    public class Patient_Profile_Page_Locator:WebdriverSession
    {
        public By By_Patient_Profile_Confirmation_Text = By.XPath("//span[@style='text-transform:capitalize;']");
        public IWebElement Web_Patient_Profile_Confirmation_Text => driver.FindElement(By_Patient_Profile_Confirmation_Text);

        public By By_Find_Provider_Link = By.CssSelector("#liFindDoctor");
        public IWebElement Web_Find_Provider_Link => driver.FindElement(By_Find_Provider_Link);

       








    }

}
