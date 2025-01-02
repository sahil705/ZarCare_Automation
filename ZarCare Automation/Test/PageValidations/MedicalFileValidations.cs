
namespace ZarCare_Automation.Test.PageValidations
{
    public class MedicalFileValidations 
    {
        public static string PatientProfileJson = "PatientProfile";
        public static string LoginJson = "Login";
        
        public static void ValidatePatientProfileOnMedicalFiles()
        {
            var Json = Json_Reader.GetDataFromJson(PatientProfileJson);
            string ptName = Json["Pt_Name"].ToString();

            PatientProfileValidations.SubmitPatientProfileDetails();

            Reports.childLog.Log(Status.Info, "Step 4: Verify patient details on medicalfiles page");
            Patient_Dashboard_Page.NavigateToMedicalFiles();
            MedicalFiles_Page.Get_And_Validate_PatientName(ptName);

            Reports.childLog.Log(Status.Info, "=================================================");
        }
    }
}
