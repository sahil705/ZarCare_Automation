namespace ZarCare_Automation.Test.PageValidations
{
    public class ContactUsValidation
    {
        public static string classname = "ContactUs";

        public static void SubmitContactUsForm()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string contactName = json["Contact_Name"].ToString();
            string contactEmail = json["Contact_Email"].ToString();
            string contactEnquiry = json["Contact_Enquiry"].ToString();
            string successMessage = json["Success_Message"].ToString();

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
            var json = Json_Reader.GetDataFromJson(classname);
            string invalidName = json["Contact_Invalid_Name"].ToString();
            string invalidEmail = json["Contact_Invalid_Email"].ToString();
            string validationName = json["Contact_Inavalid_Name_Error"].ToString();
            string validationEmail = json["Contact_Invalid_Email_Error"].ToString();
            

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

        public static void ValidateRequiredFieldsOnContactUs()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string requiredName = json["Contact_Name_Error"].ToString();
            string requiredEmail = json["Contact_Email_Error"].ToString();
            string requiredenquiry = json["Contact_Enquiry_Error"].ToString();

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
