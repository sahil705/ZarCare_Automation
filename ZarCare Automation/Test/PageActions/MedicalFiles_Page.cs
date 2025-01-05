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

        public static void Get_And_Validate_PatientName(string patientName)
        {
            string Capture_Text = Generic_Utils.getText(MedicalFilesPage.Web_Patient_Name);
            Assert.That(patientName, Is.EqualTo(Capture_Text));
        }
        public static bool Get_Medical_File_Status(string patientName)
        {
            Patient_Dashboard_Page.NavigateToMedicalFiles();
            MedicalFiles_Page.Validate_MedicalFiles_Page();

            IList<IWebElement> getMedicalFileCards = MedicalFilesPage.Web_MedicalFile_Cards;

            foreach (IWebElement element in getMedicalFileCards)
            {
                IWebElement getName = element.FindElement(MedicalFilesPage.By_MedicalFile_Name);
                string cardName = getName.Text;

                if (cardName.Equals(patientName, StringComparison.OrdinalIgnoreCase))
                {
                    string medicalFileStatus = element.FindElement(MedicalFilesPage.By_MedicalFile_Status).Text;
                    
                    if (medicalFileStatus.Equals("Incomplete", StringComparison.OrdinalIgnoreCase) || medicalFileStatus.Equals("In Progress", StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                    break;
                }
            }
            return true;    

        }
    }
}
