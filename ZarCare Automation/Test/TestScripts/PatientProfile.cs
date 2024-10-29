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


    }
}
