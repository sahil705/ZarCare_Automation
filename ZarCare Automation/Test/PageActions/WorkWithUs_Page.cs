using System.Security.Permissions;
using TestScripts;

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

        public static void ClickToSubmitButton()
        {
            WorkPage.Web_Submit_Button.Click();
        }


        public static void WorkWithUs_Form_Submission_With_New_Data(string firstName, string surName, string cellPhone, string email, string professionValue, string provinceValue, string city, string serviceValue)
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

           Reports.childLog.Log(Status.Info, "Work With Us Form Submitted");
           Generic_Utils.GetScreenshot("Work With Us Screenshot");
        }

        public static void Check_Duplicate_Email_From_Database(string email)
        {
            Database_Utils.Check_WorkWithUs_Table_ForMultipleEntries(email);
        }

        public static void WorkWithUs_Form_Submission_With_Existing_Data(string firstName, string surName, string cellPhone, string email, string professionValue, string provinceValue, string city, string serviceValue)
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

            Reports.childLog.Log(Status.Info, "Work With Us Form Submitted");
            Generic_Utils.GetScreenshot("Work With Us Screenshot");
        }

        public static void Get_And_Validate_ErrorMessage_WorkWithUs(string WorkWithUsErrorMessage)
        {
            Wait.GenericWait(3000);
            string Capture_ErrorMessage = Generic_Utils.getText(WorkPage.Web_WorkWithUs_Error_Message);
            Assert.That(WorkWithUsErrorMessage, Is.EqualTo(Capture_ErrorMessage));

            Reports.childLog.Log(Status.Info, "Error Message is displayed when user enters existing details in form");
            Generic_Utils.GetScreenshot("Work With Us Form Error Message Screenshot");
        }


        public static void Get_and_Validate_WorkWithUs_Success_Message(string Original_Text)
        {
            Wait.ElementIsVisible(WorkPage.By_Confirmation_Popup, 10);
            string Capture_Title = Generic_Utils.getText(WorkPage.Web_Work_With_Us_Success_Message_Text);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title));
            WorkPage.Web_Confirmation_Popup_Close_Icon.Click();
        }


        public static void Get_and_Validate_FirstName_Error(string FirstNameError)
        {
            string Capture_Title1 = Generic_Utils.getText(WorkPage.Web_FirstName_Validation);
            Assert.That(FirstNameError, Is.EqualTo(Capture_Title1));
        }

        public static void Get_and_Validate_SurName_Error(string Original_Text)
        {
            string Capture_Title2 = Generic_Utils.getText(WorkPage.Web_SurName_Validation);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title2));
        }

        public static void Get_and_Validate_Web_CellPhone_Error(string Original_Text)
        {
            string Capture_Title3 = Generic_Utils.getText(WorkPage.Web_CellPhone_Validation);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title3));
        }

        public static void Get_and_Validate_Email_Error(string Original_Text)
        {
            string Capture_Title4 = Generic_Utils.getText(WorkPage.Web_Email_Validation);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title4));
        }

        public static void Get_and_Validate_Profession_Error(string Original_Text)
        {
            string Capture_Title5 = Generic_Utils.getText(WorkPage.Web_Profession_Validation);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title5));
        }

        public static void Get_and_Validate_Province_Error(string Original_Text)
        {
            string Capture_Title6 = Generic_Utils.getText(WorkPage.Web_Province_Validation);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title6));
        }

        public static void Get_and_Validate_City_Error(string Original_Text)
        {
            string Capture_Title7 = Generic_Utils.getText(WorkPage.Web_City_Validation);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title7));
        }

        public static void Get_and_Validate_Current_WorkPlace_Error(string Original_Text)
        {
            string Capture_Title8 = Generic_Utils.getText(WorkPage.Web_Current_WorkPlace_Validation);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title8));
        }
    }
}
