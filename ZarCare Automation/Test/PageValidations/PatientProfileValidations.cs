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

            Reports.childLog.Log(Status.Info, "Step 3: Submit Patient Profile ");
            Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
            Patient_Dashboard_Page.NavigateToPatientProfile();
            Patient_Profile_Page.ValidatePatientProfile();
            Patient_Profile_Page.SubmitPatientProfileInfo(firstName, lastName, patientWeight, patientHeight, patientGender, patientAddress, patientSuburb, patientCity, patientProvince, postalCode, successMessage);

            Reports.childLog.Log(Status.Info, "=================================================");
        }

    }
}
