namespace ZarCare_Automation.Test.PageActions
{
    public class ContactUs_Page : WebdriverSession
    {
        public static ContactUs_Locators contact_Us = new ContactUs_Locators();

        public static void Validate_Contact_Us_Page()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(contact_Us.By_PageHeaderElement);

            Reports.childLog.Log(Status.Info, "Contact us page displayed");
            Generic_Utils.GetScreenshot("Contact us page screenshot");
        }

        public static void SubmitContactUsForm(string contactName, string contactEmail, string contactEnquiry, string successMessage)
        {
            Generic_Utils.ClearTextBox(contact_Us.Web_Contact_Name);
            contact_Us.Web_Contact_Name.SendKeys(contactName);

            Generic_Utils.ClearTextBox(contact_Us.Web_Contact_email);
            contact_Us.Web_Contact_email.SendKeys(contactEmail);

            Generic_Utils.ClearTextBox(contact_Us.Web_Contact_Enquiry);
            contact_Us.Web_Contact_Enquiry.SendKeys(contactEnquiry);

            contact_Us.Web_Button_Submit.Click();

            Wait.ElementIsVisible(contact_Us.By_ThankYou_Page_Success_Message, 10);
            string thankyouText = contact_Us.Web_ThankYou_Page_Success_Message.Text;
            Assert.That(thankyouText, Is.EqualTo(successMessage));

            Reports.childLog.Log(Status.Info, "ContactUs Form Submitted Successfully");
            Generic_Utils.GetScreenshot("ContactUs Form Screenshot With Success Message");

        }

        public static void ValidateContactUsForm(string contactName, string contactEmail, string nameValidation, string emailValidation)
        {
            Generic_Utils.ClearTextBox(contact_Us.Web_Contact_Name);
            contact_Us.Web_Contact_Name.SendKeys(contactName);

            Generic_Utils.ClearTextBox(contact_Us.Web_Contact_email);
            contact_Us.Web_Contact_email.SendKeys(contactEmail);

            contact_Us.Web_Button_Submit.Click();

            string getNameValidationMessage = contact_Us.Web_ContactUs_Name_Error.Text;
            string getEmailValidationMessage = contact_Us.Web_ContactUs_Email_Error.Text;

            Assert.Multiple(() =>
            {
                Assert.That(getNameValidationMessage, Is.EqualTo(nameValidation));
                Assert.That(getEmailValidationMessage, Is.EqualTo(emailValidation));
            });

            Reports.childLog.Log(Status.Info, "Validation Fires on the ContactUs Page");
            Generic_Utils.GetScreenshot("ContactUs Form Screenshot With Validation");

        }

        public static void ValidateRequiredFields(string nameValidation, string emailValidation, string enquiryValidation)
        {
            contact_Us.Web_Button_Submit.Click();

            string getRequiredNameValidation = contact_Us.Web_ContactUs_Name_Error.Text;
            string getRequiredEmailValidation = contact_Us.Web_ContactUs_Email_Error.Text;
            string getRequiredEnquiryValidation = contact_Us.Web_ContactUs_Enquiry_Error.Text;

            Assert.Multiple(() =>
            {
                Assert.That(getRequiredNameValidation, Is.EqualTo(nameValidation));
                Assert.That(getRequiredEmailValidation, Is.EqualTo(emailValidation));
                Assert.That(getRequiredEnquiryValidation, Is.EqualTo(enquiryValidation));
            });

            Reports.childLog.Log(Status.Info, "Validation Fires on the ContactUs Page");
            Generic_Utils.GetScreenshot("ContactUs Form Screenshot With Validation");
        }
    }
}
