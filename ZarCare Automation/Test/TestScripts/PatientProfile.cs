namespace TestScripts
{
    public class PatientProfile:Base
    {
        [Test]
        public void SubmitPatientProfileAndUploadBankDetails()
        {
            Reports.childLog = Reports.CreateNode("Submit the Patient Profile Form ");
            PatientProfileValidations.SubmitPatientProfileDetails();           
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Upload Banking Details ");
            PatientProfileValidations.uploadBankingDetail();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void SubmitAndVerifyEmptyPatientProfile()
        {
            Reports.childLog = Reports.CreateNode("Submit the empty Patient Profile");
            PatientProfileValidations.ValidateRequiredFieldsPatientProfile();
            Reports.FlushNode(Reports.childLog);
        }
    }
}
