namespace ZarCare_Automation.Test.PageActions
{
    public class Work_With_Us_Page : WebdriverSession
    {
        public static Work_With_Us_Locators Work_With_Us = new Work_With_Us_Locators();

        public static void Validate_WorkWithUs()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(Work_With_Us.By_Work_With_Us_Text);
            
            Reports.childLog.Log(Status.Info, "WorkWithUs Page is displayed");
            Generic_Utils.GetScreenshot("WorkWithUs page screenshot");
        }

        public static void Get_and_Validate_WorkWithUs_Text(string Original_Text)
        {
            string Capture_Title = Generic_Utils.getText(Work_With_Us.Web_Work_With_Us_Text);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title));
        }


        public static void NavigateToSubmitButton()
        {
            Work_With_Us.Web_Submit_Button.Click();
        }

        public static void Get_and_Validate_FirstName_Error(string FirstNameError)
        {
            string Capture_Title1 = Generic_Utils.getText(Work_With_Us.Web_FirstName_Error);
            Assert.That(FirstNameError, Is.EqualTo(Capture_Title1));
        }

        public static void Get_and_Validate_SurName_Error(string Original_Text)
        {
            string Capture_Title2 = Generic_Utils.getText(Work_With_Us.Web_SurName_Error);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title2));
        }

        public static void Get_and_Validate_Web_CellPhone_Error(string Original_Text)
        {
            string Capture_Title3 = Generic_Utils.getText(Work_With_Us.Web_CellPhone_Error);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title3));
        }

        public static void Get_and_Validate_Email_Error(string Original_Text)
        {
            string Capture_Title4 = Generic_Utils.getText(Work_With_Us.Web_Email_Error);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title4));
        }

        public static void Get_and_Validate_Profession_Error(string Original_Text)
        {
            string Capture_Title5 = Generic_Utils.getText(Work_With_Us.Web_Profession_Error);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title5));
        }

        public static void Get_and_Validate_Province_Error(string Original_Text)
        {
            string Capture_Title6 = Generic_Utils.getText(Work_With_Us.Web_Province_Error);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title6));
        }

        public static void Get_and_Validate_City_Error(string Original_Text)
        {
            string Capture_Title7 = Generic_Utils.getText(Work_With_Us.Web_City_Error);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title7));
        }

        public static void Get_and_Validate_Current_WorkPlace_Error(string Original_Text)
        {
            string Capture_Title8 = Generic_Utils.getText(Work_With_Us.Web_Current_WorkPlace_Error);
            Assert.That(Original_Text, Is.EqualTo(Capture_Title8));
        }
    }
}
