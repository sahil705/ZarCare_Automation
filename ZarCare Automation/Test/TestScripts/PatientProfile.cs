using AventStack.ExtentReports.Core;

namespace TestScripts
{
    public class PatientProfile:Base
    {
        [Test]
        public void SubmitAndVerifyPatientProfile()
        {
            Reports.childLog = Reports.CreateNode("Submit the Patient Profile Form ");
            PatientProfileValidations.SubmitPatientProfileDetails();           
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void SubmitAndVerifyEmptyPatientProfile()
        {
            Reports.childLog = Reports.CreateNode("Submit the empty Patient Profile");
            PatientProfileValidations.ValidateRequiredFieldsPatientProfile();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void SubmitEmptyBankingFile()
        {
            Reports.childLog = Reports.CreateNode("Submit the empty banking file without consent");
            PatientProfileValidations.ValidateEmptyBankingFileUpload();
            Reports.FlushNode(Reports.childLog);
        }

       
        [Test]
        public void DownloadBankingFile()
        {
            Reports.childLog = Reports.CreateNode("Download and validate Banking file");
            PatientProfileValidations.DownloadAndvalidateBankingFile();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void ValidatePatientProfileOnDashboard()
        {
            Reports.childLog = Reports.CreateNode("Update and validate patient profile on Dashboard");
            PatientDashboardValidations.ValidatePatientProfileOnDashboard();
            Reports.FlushNode(Reports.childLog);
          
        }

        [Test]
        public void ValidatePatientProfileOnMedicalFiles()
        {
            Reports.childLog = Reports.CreateNode("Update and Validate Patient profile on medical files");
            MedicalFileValidations.ValidatePatientProfileOnMedicalFiles();
            Reports.FlushNode(Reports.childLog);

        }

        [Test]  
        public void UploadAndValidateProfilePhoto()
        {
            Reports.childLog = Reports.CreateNode("Upload and validate patient profile photo");
            PatientProfileValidations.UploadProfilePic();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void ValidateProfilePicFileSize()
        {
            Reports.childLog = Reports.CreateNode("Upload and validate patient profilepic maxminu file size");
            PatientProfileValidations.ValidateProfilePicMaxSize();
            Reports.FlushNode(Reports.childLog);
        }
    }
}
