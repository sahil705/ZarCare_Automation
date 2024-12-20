namespace ZarCare_Automation.Test.PageActions
{
    public class Patient_Profile_Page : WebdriverSession
    {

        public static Patient_Profile_Page_Locators PatientProfile = new Patient_Profile_Page_Locators();
        public static void ValidatePatientProfile()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(PatientProfile.By_ProfilePicture_Text);

            Reports.childLog.Log(Status.Info, "Patient Profile page is displayed");
            Generic_Utils.GetScreenshot("Patient Profile screenshot");
        }
        public static void SubmitPatientProfileInfo(string fName, string lName, string weight, string height, string gender, string address, string suburb, string city, string province, string postalCode, string successText)
        {
            Generic_Utils.ClearTextBox(PatientProfile.Web_FirstName_Textbox);
            PatientProfile.Web_FirstName_Textbox.SendKeys(fName);

            Generic_Utils.ClearTextBox(PatientProfile.Web_LastName_Textbox);
            PatientProfile.Web_LastName_Textbox.SendKeys(lName);

            Generic_Utils.ClearTextBox(PatientProfile.Web_Weight_Textbox);
            PatientProfile.Web_Weight_Textbox.SendKeys(weight);

            Generic_Utils.ClearTextBox(PatientProfile.Web_Height_Textbox);
            PatientProfile.Web_Height_Textbox.SendKeys(height);

            IWebElement patientGender = PatientProfile.Web_Gender_Dropdown;
            Generic_Utils.Dropdown_Handle_With_Value(patientGender, gender);

            Generic_Utils.ClearTextBox(PatientProfile.Web_Address_Textbox);
            PatientProfile.Web_Address_Textbox.SendKeys(address);

            Generic_Utils.ClearTextBox(PatientProfile.Web_SubUrb_Textbox);
            PatientProfile.Web_SubUrb_Textbox.SendKeys(suburb);

            Generic_Utils.ClearTextBox(PatientProfile.Web_City_Textbox);
            PatientProfile.Web_City_Textbox.SendKeys(city);

            Generic_Utils.ClearTextBox(PatientProfile.Web_Province_Textbox);
            PatientProfile.Web_Province_Textbox.SendKeys(province);

            Generic_Utils.ClearTextBox(PatientProfile.Web_PostalCode_Textbox);
            PatientProfile.Web_PostalCode_Textbox.SendKeys(postalCode);

            PatientProfile.Web_Submit_Button.Click();

            Wait.ElementIsVisible(PatientProfile.By_Success_Message, 10);

            string successMessage = Generic_Utils.getText(PatientProfile.Web_Success_Message);

            Assert.That(successMessage, Does.Contain(successText));

            Reports.childLog.Log(Status.Info, "Patient Profile Submitted");
            Generic_Utils.GetScreenshot("Patient Profile screenshot");
        }

        public static void NavigateToDashboard()
        {
            PatientProfile.Web_LeftMenu_Dashboard_Link.Click();
        }
        public static string GetFullName()
        {
            string firstName = PatientProfile.Web_FirstName_Textbox.GetAttribute("value");
            string lastName = PatientProfile.Web_LastName_Textbox.GetAttribute("value");
            string fullName = " " + firstName + " " + lastName;
            return fullName;
        }

        public static string GetGender()
        {
            string gender = PatientProfile.Web_Gender_Dropdown.GetAttribute("value");
            return " " + gender;
        }

        public static string GetWeight()
        {
            string weight = PatientProfile.Web_Weight_Textbox.GetAttribute("value");
            return " " + weight + " " + "kg";
        }

        public static string GetHeight()
        {
            string height = PatientProfile.Web_Height_Textbox.GetAttribute("value");
            return " " + height + " " + "cm";
        }

        public static string GetFullAddress()
        {
            string address = PatientProfile.Web_Address_Textbox.GetAttribute("value");
            string suburb = PatientProfile.Web_SubUrb_Textbox.GetAttribute("value");
            string city = PatientProfile.Web_City_Textbox.GetAttribute("value");
            string province = PatientProfile.Web_Province_Textbox.GetAttribute("value");
            string postalCode = PatientProfile.Web_PostalCode_Textbox.GetAttribute("value");
            string fullAddress = " " + address + " " + suburb + " " + city + " " + province + " " + postalCode;
            return fullAddress;
        }
        public static void SubmitPatientProfileEmptyInfo()
        {
            Generic_Utils.ClearTextBox(PatientProfile.Web_FirstName_Textbox);

            Generic_Utils.ClearTextBox(PatientProfile.Web_LastName_Textbox);

            Generic_Utils.ClearTextBox(PatientProfile.Web_Weight_Textbox);

            Generic_Utils.ClearTextBox(PatientProfile.Web_Height_Textbox);

            Generic_Utils.ClearTextBox(PatientProfile.Web_Address_Textbox);

            Generic_Utils.ClearTextBox(PatientProfile.Web_SubUrb_Textbox);

            Generic_Utils.ClearTextBox(PatientProfile.Web_City_Textbox);

            Generic_Utils.ClearTextBox(PatientProfile.Web_Province_Textbox);

            Generic_Utils.ClearTextBox(PatientProfile.Web_PostalCode_Textbox);

            PatientProfile.Web_Submit_Button.Click();
        }
       
        public static void Get_And_Validate_firstName_Error(string Original_Text1)
        {
            string Capture_Text1 = Generic_Utils.getText(PatientProfile.Web_FirstName_Validation);
            Assert.That(Original_Text1, Is.EqualTo(Capture_Text1));
        }
        public static void Get_And_Validate_lastName_Error(string Original_Text2)
        {
            string Capture_Text2 = Generic_Utils.getText(PatientProfile.Web_LastName_Validation);
            Assert.That(Original_Text2, Is.EqualTo(Capture_Text2));
        }
        public static void Get_And_Validate_Weight_Error(string Original_Text3)
        {
            string Capture_Text3 = Generic_Utils.getText(PatientProfile.Web_Weight_Validation);
            Assert.That(Original_Text3, Is.EqualTo(Capture_Text3));
        }
        public static void Get_And_Validate_Height_Error(string Original_Text4)
        {
            string Capture_Text4 = Generic_Utils.getText(PatientProfile.Web_Height_Validation);
            Assert.That(Original_Text4 , Is.EqualTo(Capture_Text4));
        }
    }
}