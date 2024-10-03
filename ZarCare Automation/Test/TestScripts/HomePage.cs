namespace TestScripts
{

    public class HomePage : Base
    {
        [Test]
        public void Validate_Redirection_On_HomePageLinks()
        {
            Reports.childLog = Reports.CreateNode("Validate Home Page Links Redirection");
            HomePageValidation.Validate_Redirection_To_OurProvider();
            Generic_Utils.NavigateBack();
            HomePageValidation.Verify_Redirection_To_Video_Consult_Page();
            Generic_Utils.NavigateBack();
            HomePageValidation.Validate_Redirection_To_WorkWithUs_Page();
            Generic_Utils.NavigateBack();
            HomePageValidation.Validate_Redirection_To_Blog_Page(); 
            Generic_Utils.NavigateBack();
            HomePageValidation.Validate_Redirection_To_Login_Page();
            Generic_Utils.NavigateBack();
            HomePageValidation.Validate_Redirection_To_Faq();
            Generic_Utils.NavigateBack();
            HomePageValidation.Validate_Redirection_To_ContactUs_Page();
            Generic_Utils.NavigateBack();
            HomePageValidation.Validate_Redirection_To_AboutUs();
            Generic_Utils.NavigateBack();
            HomePageValidation.Validate_SpecialtyCard_Redirection_To_OurProvider();
            Generic_Utils.NavigateBack();
            HomePageValidation.Verify_ConnectNowPopup_Redirection_To_OurProviders();
            Reports.FlushNode(Reports.childLog);

        }


        [Test]
        public void Verify_Validation_Message_On_Subscribe_To_Newsletter()
        {
             var json = Json_Reader.GetDataFromJson(classname);
             string Invalid_Email = json["Invalid_email"].ToString();
             string Original_Error_Message = json["OriginalErrorMessage"].ToString();
                     
             Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

             Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Newsletter Section");
             Home_Page.Validate_HomePage();
             Home_Page.ValidateNewsletterSection();
             Reports.FlushNode(Reports.childLog);

             Reports.childLog = Reports.CreateNode("Step 2: Enter the Invalid Email and Verify the error message");
             Home_Page.Enter_InvalidEmail_To_Subscribe_Textbox(Invalid_Email);
             Home_Page.ClickSubscribeButton();
             Home_Page.GetAndValidateNewsletterErrorMessage(Original_Error_Message);
             Reports.FlushNode(Reports.childLog);

        }

        [Test]
        public void Validate_NewsLatter_Success_Message()
        {
              var json = Json_Reader.GetDataFromJson(classname);
              string ActualMessage = json["Actual_Message"].ToString();
              string News_LatterEmail = json["NewsLatterEmail"].ToString();

              Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

              Reports.childLog = Reports.CreateNode("Step 1: Open and validate home page");
              Home_Page.Validate_HomePage();
              Reports.FlushNode(Reports.childLog);

              Reports.childLog = Reports.CreateNode("Step 2: Validate news latter email success message");
              Home_Page.EnterNewslatterEmail(News_LatterEmail);
              Home_Page.Validate_NewLatterEmailMessage(ActualMessage);
              Reports.FlushNode(Reports.childLog);

        }

    }
}