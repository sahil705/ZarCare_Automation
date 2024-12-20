namespace TestScripts
{
    public class ContactUs:Base
    {
        [Test]
        public void ContactUsFormSubmission()
        {
            Reports.childLog = Reports.CreateNode("Verify the ContactUs Form Submission");
            ContactUsValidation.SubmitContactUsForm();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Validate the ContactUs Form With Invalid Data ");
            ContactUsValidation.ValidateContactUsFormWithInvalidInputs();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Validate Required Fields On ContactUs Page ");
            ContactUsValidation.ValidateRequiredFieldsOnContactUs();
            Reports.FlushNode(Reports.childLog);
        }
    }
}
