using System.Xml.Linq;

namespace ZarCare_Automation.Test.PageActions
{
    public class Patient_Dashboard_Page:WebdriverSession
    {
        public static Patient_Dashboard_Page_Locator PatientDashboardPage = new Patient_Dashboard_Page_Locator();
        public static void ValidatePatientDashboard()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(PatientDashboardPage.By_Patient_Dashboard_Confirmation_Text);


            Reports.childLog.Log(Status.Info, "Patient Dashboard page is displayed");
            Generic_Utils.GetScreenshot("Patient Dashboard screenshot");
        }

        public static void HandleNotificationPopupOnDashboard()
        {
            try
            {
                Wait.ElementIsVisible(PatientDashboardPage.By_Notification_Popup, 10);
                
                IWebElement laterButton = Wait.ElementIsClickable(PatientDashboardPage.Web_Later_Button, 10);
                Generic_Utils.JavaScriptElementClick(laterButton);  

                Wait.InvisibleOfElement(PatientDashboardPage.By_Notification_Popup, 10);

                Console.WriteLine("Popup closed successfully.");
            }
            
            catch (WebDriverTimeoutException)
            {
                
                Console.WriteLine("No popup displayed.");
            }
        }

        public static void NavigateToFindProviderPage()
        {
            IWebElement providerLink =  Wait.ElementIsClickable(PatientDashboardPage.Web_Find_Provider_Link, 10);
            providerLink.Click();
        }

        public static void NavigateToActiveAppointment()
        {
            Generic_Utils.ScrollToMiddle();
            Generic_Utils.ScrollToElement(PatientDashboardPage.Web_Active_Appointment_View_All_Link);
            PatientDashboardPage.Web_Active_Appointment_View_All_Link.Click();    
        }

        public static void NavigateToPatientProfile()
        {
            IWebElement patientProfileLink = Wait.ElementIsVisible(PatientDashboardPage.By_Update_Icon,10);
            patientProfileLink.Click(); 
        }

        public static void NavigateToPatientProfileThroughProfilePicIcon()
        {
            PatientDashboardPage.Web_ProfilePic_Icon.Click();   
        }

        public static void ValidatePatientDetailInPatientDashboard(string fName, string lName, string weight, string height, string gender, string address, string suburb, string city, string province, string postalCode, string successText)
        {
            Patient_Profile_Page.SubmitPatientProfileInfo(fName, lName, weight, height, gender, address, suburb, city, province, postalCode, successText);
            string getProfileFullName = Patient_Profile_Page.GetFullName();
            string getProfileGender = Patient_Profile_Page.GetGender(); 
            string getProfileWeight = Patient_Profile_Page.GetWeight(); 
            string getProfileHeight = Patient_Profile_Page.GetHeight(); 
            string getProfileAddress = Patient_Profile_Page.GetFullAddress();   

            Patient_Profile_Page.NavigateToDashboard();
            ValidatePatientDashboard();

            string nameText = PatientDashboardPage.Web_PatientName.Text;
            string genderText = PatientDashboardPage.Web_Patient_Gender.Text;
            string weightText = PatientDashboardPage.Web_Patient_Weight.Text;
            string heightText = PatientDashboardPage.Web_Patient_Height.Text;
            string addressText = PatientDashboardPage.Web_Patient_Address.Text;

            Assert.Multiple(() =>
            {
                Assert.That(getProfileFullName, Is.EqualTo(nameText));
                Assert.That(getProfileGender, Is.EqualTo(genderText));
                Assert.That(getProfileWeight, Does.Contain(weightText));
                Assert.That(getProfileHeight, Does.Contain(heightText));
                Assert.That(getProfileAddress, Is.EqualTo(addressText));
            });

            Reports.childLog.Log(Status.Info, "Patient Dashboard Information matched with Patient Profile Page");
            Generic_Utils.GetScreenshot("Profile Dashboard Personal Detail Section screenshot");
        }
    }
}
