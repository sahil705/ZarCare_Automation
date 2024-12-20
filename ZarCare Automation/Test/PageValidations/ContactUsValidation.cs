namespace ZarCare_Automation.Test.PageValidations
{
    public class ContactUsValidation
    {
        public static string classname = "ContactUs";

        public static void SubmitContactUsForm()
        {
            var json = Json_Reader.GetArrayFromJson(classname, "validContactUsData");
            string contactName = json[0]["Contact_Name"].ToString();
            string contactEmail = json[0]["Contact_Email"].ToString();
            string contactEnquiry = json[0]["Contact_Enquiry"].ToString();
            string successMessage = Json_Reader.GetArrayFromJson(classname, "successMessages")[0]["Success_Message"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "ContactUs Form Submission ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToContactUs();

            Reports.childLog.Log(Status.Info, "Step 2: Submit the ContactUs detail ");
            ContactUs_Page.Validate_Contact_Us_Page();
            ContactUs_Page.SubmitContactUsForm(contactName, contactEmail, contactEnquiry, successMessage);

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void ValidateContactUsFormWithInvalidInputs()
        {
            var json = Json_Reader.GetArrayFromJson(classname, "invalidContactFormData");
            var errorMessages = Json_Reader.GetArrayFromJson(classname, "errorMessages");

            foreach (var invalidData in json)
            {
                string invalidName = invalidData["Contact_Invalid_Name"].ToString();
                string invalidEmail = invalidData["Contact_Invalid_Email"].ToString();
                string validationName = errorMessages[3]["Contact_Inavalid_Name_Error"].ToString();
                string validationEmail = errorMessages[4]["Contact_Invalid_Email_Error"].ToString();

                Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");
                Reports.childLog.Log(Status.Info, "Verify ContactUs Form Validation ");
                Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
                Home_Page.Validate_HomePage();
                Home_Page.NavigateToContactUs();
                Reports.childLog.Log(Status.Info, "Step 2: Validate the ContactUs Fields With Invalid Data ");
                ContactUs_Page.Validate_Contact_Us_Page();
                ContactUs_Page.ValidateContactUsForm(invalidName, invalidEmail, validationName, validationEmail);

                Reports.childLog.Log(Status.Info, "=================================================");
            }
        }

        public static void ValidateRequiredFieldsOnContactUs()
        {
            var errorMessages = Json_Reader.GetArrayFromJson(classname, "errorMessages");
            string requiredName = errorMessages[0]["Contact_Name_Error"].ToString();
            string requiredEmail = errorMessages[1]["Contact_Email_Error"].ToString();
            string requiredenquiry = errorMessages[2]["Contact_Enquiry_Error"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");
            Reports.childLog.Log(Status.Info, "Verify ContactUs Form Validation ");
            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToContactUs();
            Reports.childLog.Log(Status.Info, "Step 2: Validate Required Fields On ContactUs ");
            ContactUs_Page.Validate_Contact_Us_Page();
            ContactUs_Page.ValidateRequiredFields(requiredName, requiredEmail, requiredenquiry);

            Reports.childLog.Log(Status.Info, "=================================================");
        }
    }
}
