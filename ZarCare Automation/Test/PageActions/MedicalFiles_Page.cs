
using TestScripts;

namespace ZarCare_Automation.Test.PageActions
{
    public class MedicalFiles_Page:WebdriverSession
    {
        public static Medical_Files_Locators MedicalFilesPage = new Medical_Files_Locators();
        
        public static void Validate_MedicalFiles_Page()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(MedicalFilesPage.By_MedicalFile_Header);

            Reports.childLog.Log(Status.Info, "Medical files page is displayed");
            Generic_Utils.GetScreenshot("Medical files page screenshot");
        }

        public static void Get_And_Validate_PatientName(string Patientname)
        {
            string Capture_Text = Generic_Utils.getText(MedicalFilesPage.Web_Patient_Name);
            Assert.That(Patientname, Is.EqualTo(Capture_Text));
        }
    }
}
