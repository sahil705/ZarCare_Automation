namespace ZarCare_Automation.Test.PageActions
{
    public class WorkWithUs_Page:WebdriverSession
    {
        public static WorkWithUs_Locators WorkPage = new WorkWithUs_Locators();

        public static void Validate_WorkWithUs()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(WorkPage.By_Confirmation_Popup);

            Reports.childLog.Log(Status.Info, "WorkWithUs page is displayed");
            Generic_Utils.GetScreenshot("WorkWithUs screenshot");
        }
              
        
        public static void WorkWithUs_Form_Submission(string firstName, string surName, string cellPhone, string email, string professionValue, string provinceValue, string city, string serviceValue)
        {
            WorkPage.Web_First_Name.SendKeys(firstName);
            WorkPage.Web_Sur_Name.SendKeys(surName);    
            WorkPage.Web_CellPhone_Number.SendKeys(cellPhone);  
            WorkPage.Web_Email.SendKeys(email); 

            IWebElement professionDropdown = WorkPage.Web_Profession_Dropdown;
            Generic_Utils.Dropdown_Handle_With_Value(professionDropdown, professionValue);

            IWebElement provinceDropdown = WorkPage.Web_Province_Dropdown;
            Generic_Utils.Dropdown_Handle_With_Text(provinceDropdown, provinceValue);

            WorkPage.Web_City.SendKeys(city);   

            IWebElement serviceDropdown = WorkPage.Web_Service_Dropdown;
            Generic_Utils.Dropdown_Handle_With_Text(serviceDropdown, serviceValue);

            IWebElement submitButton = WorkPage.Web_Submit_Button;  
            Generic_Utils.Action_For_Double_Click(submitButton);

            Wait.ElementIsVisible(WorkPage.By_Confirmation_Popup, 10);

           // WorkPage.Web_Confirmation_Popup_Close_Icon.Click();

            Database_Utils.Check_WorkWithUs_Table_ForMultipleEntries(email);


        }
    }
}
