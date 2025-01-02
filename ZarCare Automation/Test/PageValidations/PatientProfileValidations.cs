using System.Xml.Linq;

namespace ZarCare_Automation.Test.PageValidations
{
    public class PatientProfileValidations
    {
        public static string PatientProfileJson = "PatientProfile";
        public static string LoginJson = "Login";

        public static void SubmitPatientProfileDetails()
        {
            var json = Json_Reader.GetDataFromJson(PatientProfileJson);
            var loginJson = Json_Reader.GetDataFromJson(LoginJson);
            string firstName = json["First_Name"].ToString();
            string lastName = json["Last_Name"].ToString();
            string patientWeight = json["Weight"].ToString();
            string patientHeight = json["Height"].ToString();
            string patientGender = json["Gender"].ToString();
            string patientAddress = json["Address"].ToString();
            string patientSuburb = json["Suburb"].ToString();
            string patientCity = json["City"].ToString();
            string patientProvince = json["Province"].ToString();
            string postalCode = json["PostalCode"].ToString();
            string successMessage = json["Success_Message"].ToString();
            string patientEmail = loginJson["Email"].ToString();
            string patientPassword = loginJson["Password"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Patient Detail On Patient Dashboard ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Login as a Patient and Validate the Patient Dashboard ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(patientEmail, patientPassword);
            Patient_Dashboard_Page.ValidatePatientDashboard();

            Reports.childLog.Log(Status.Info, "Step 3: Submit Patient Profile Details ");
            Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
            Patient_Dashboard_Page.NavigateToPatientProfile();
            Patient_Profile_Page.ValidatePatientProfile();
            Patient_Profile_Page.SubmitPatientProfileInfo(firstName, lastName, patientWeight, patientHeight, patientGender, patientAddress, patientSuburb, patientCity, patientProvince, postalCode, successMessage);



            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void ValidateRequiredFieldsPatientProfile()
        {
            var json = Json_Reader.GetDataFromJson(PatientProfileJson);
            var loginJson = Json_Reader.GetDataFromJson(LoginJson);
            string firstName_error = json["FirstName_Validation"].ToString();
            string lastName_error = json["LastName_Validation"].ToString();
            string patientWeight_error = json["Weight_Validation"].ToString();
            string patientHeight_error = json["Height_Validation"].ToString();
            string patientEmail = loginJson["Email"].ToString();
            string patientPassword = loginJson["Password"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Patient Detail On Patient Dashboard ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Login as a Patient and Validate the Patient Dashboard ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(patientEmail, patientPassword);
            Patient_Dashboard_Page.ValidatePatientDashboard();

            Reports.childLog.Log(Status.Info, "Step 3: Submit Patient Profile ");
            Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
            Patient_Dashboard_Page.NavigateToPatientProfile();
            Patient_Profile_Page.ValidatePatientProfile();
            Patient_Profile_Page.SubmitPatientProfileEmptyInfo();
            Patient_Profile_Page.Get_And_Validate_firstName_Error(firstName_error);
            Patient_Profile_Page.Get_And_Validate_lastName_Error(lastName_error);
            Patient_Profile_Page.Get_And_Validate_Weight_Error(patientWeight_error);
            Patient_Profile_Page.Get_And_Validate_Height_Error(patientHeight_error);

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void ValidateEmptyBankingFileUpload()
        {
            var json = Json_Reader.GetDataFromJson(PatientProfileJson);
            var loginJson = Json_Reader.GetDataFromJson(LoginJson);
            string patientEmail = loginJson["Email"].ToString();
            string patientPassword = loginJson["Password"].ToString();
            string bankingConsent_Error = json["Banking_Consent_Error"].ToString();
            string banking_Error = json["BankingFile_Error"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Patient Profile Page Through Profile Pic Icon On Dashboard ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Login as a Patient and Validate the Patient Dashboard ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(patientEmail, patientPassword);
            Patient_Dashboard_Page.ValidatePatientDashboard();

            Reports.childLog.Log(Status.Info, "Step 3: Validate empty bank account details on patient profile");
            Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
            Patient_Dashboard_Page.NavigateToPatientProfile();
            Patient_Profile_Page.ValidatePatientProfile();
            Patient_Profile_Page.SubmitEmptyBankingFile();
            Patient_Profile_Page.Get_And_Validate_Empty_BankingFile_Error(banking_Error);
            Patient_Profile_Page.Get_And_Validate_Banking_Consent_Error(bankingConsent_Error);

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void DownloadAndvalidateBankingFile()
        {
            var json = Json_Reader.GetDataFromJson(PatientProfileJson);
            var loginJson = Json_Reader.GetDataFromJson(LoginJson);
            string patientEmail = loginJson["Email"].ToString();
            string patientPassword = loginJson["Password"].ToString();
            string downloadDirectory = json["DownloadDirectory"].ToString();
            string bankfileName = json["BankFileName"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Patient Profile Page Through Profile Pic Icon On Dashboard ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Login as a Patient and Validate the Patient Dashboard ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(patientEmail, patientPassword);
            Patient_Dashboard_Page.ValidatePatientDashboard();

            Reports.childLog.Log(Status.Info, "Step 3: Download bank account details on patient profile");
            Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
            Patient_Dashboard_Page.NavigateToPatientProfile();
            Patient_Profile_Page.ValidatePatientProfile();
            Patient_Profile_Page.DownloadBankingFile();
            Patient_Profile_Page.Get_And_Validate_Downloaded_Banking_File(downloadDirectory, bankfileName);
          
            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void uploadBankingDetail()
        {
            
            var json = Json_Reader.GetDataFromJson(PatientProfileJson);
            string filePath = json["Bank_Detail_File_Path"].ToString();
            string bankDetailSuccessMessage = json["Bank_Detail_Success_Message"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Submit Banking Details in Patient Profile Page ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToLoginPage();
            Generic_Utils.WindowHandle();

            Reports.childLog.Log(Status.Info, "Step 2: Validate Patient Dashboard and Submit Banking Details ");
            Patient_Dashboard_Page.ValidatePatientDashboard();
            Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
            Patient_Dashboard_Page.NavigateToPatientProfile();
            Patient_Profile_Page.ValidatePatientProfile();
            Patient_Profile_Page.UploadBankDetail(filePath, bankDetailSuccessMessage);


            Reports.childLog.Log(Status.Info, "=================================================");
        }



        public static void ValidatePatientProfileOnDashboardAndMedicalFiles()
        {
            var Json = Json_Reader.GetDataFromJson(PatientProfileJson);
            string patientName = Json["Patient_Name"].ToString();
            string patientHeight = Json["Patient_Height"].ToString();
            string patientWeight = Json["Patient_Weight"].ToString();
            string patientGender = Json["Patient_Gender"].ToString();
            string patientFullAddress = Json["Patient_FullAddress"].ToString();
            string ptName = Json["Pt_Name"].ToString();

            SubmitPatientProfileDetails();
          
            Reports.childLog.Log(Status.Info, "Step 4: Verify patient details on dashboard page");
            Patient_Profile_Page.NavigateToDashboard();
            Generic_Utils.GetScreenshot("Patient Dashboard screenshot");

            Patient_Dashboard_Page.Get_And_Validate_Patient_FullName(patientName);
            Patient_Dashboard_Page.Get_And_Validate_Patient_Height(patientHeight);
            Patient_Dashboard_Page.Get_And_Validate_Patient_Weight(patientWeight);
            Patient_Dashboard_Page.Get_And_Validate_Patient_Gender(patientGender);
            Patient_Dashboard_Page.Get_And_Validate_Patient_Address(patientFullAddress);

            Reports.childLog.Log(Status.Info, "Step 5: Verify patient details on medicalfiles page");
            Patient_Dashboard_Page.NavigateToMedicalFiles();
            MedicalFiles_Page.Get_And_Validate_PatientName(ptName);

            Reports.childLog.Log(Status.Info, "=================================================");

        }

        public static void UploadProfilePic()
        {
            var json = Json_Reader.GetDataFromJson(PatientProfileJson);
            var loginJson = Json_Reader.GetDataFromJson(LoginJson);
            string patientEmail = loginJson["Email"].ToString();
            string patientPassword = loginJson["Password"].ToString();
            string profilePhoto = json["Photo_Path"].ToString();
            string successMessage = json["Success_Message"].ToString();
           

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Upload and validate patient profile pic");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Login as a Patient and Validate the Patient Dashboard ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(patientEmail, patientPassword);
            Patient_Dashboard_Page.ValidatePatientDashboard();

            Reports.childLog.Log(Status.Info, "Step 3: Upload profile photo and validate success message");
            Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
            Patient_Dashboard_Page.NavigateToPatientProfile();
            Patient_Profile_Page.ValidatePatientProfile();
            Patient_Profile_Page.UploadProfilePhoto(profilePhoto, successMessage);
           
            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void ValidateProfilePicMaxSize()
        {
            var json = Json_Reader.GetDataFromJson(PatientProfileJson);
            var loginJson = Json_Reader.GetDataFromJson(LoginJson);
            string patientEmail = loginJson["Email"].ToString();
            string patientPassword = loginJson["Password"].ToString();
            string invalidProfilePhoto = json["Invalid_Photo_Path"].ToString();
            string errorMessage = json["Photo_Validation"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Profile pic maxmimum file size");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Login as a Patient and Validate the Patient Dashboard ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(patientEmail, patientPassword);
            Patient_Dashboard_Page.ValidatePatientDashboard();

            Reports.childLog.Log(Status.Info, "Step 3: Upload profile photo and validate max file size message");
            Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
            Patient_Dashboard_Page.NavigateToPatientProfile();
            Patient_Profile_Page.ValidatePatientProfile();
            Patient_Profile_Page.Get_And_Validate_ProfilePic_Size(invalidProfilePhoto, errorMessage);
          
            Reports.childLog.Log(Status.Info, "=================================================");
        }
    }
}
