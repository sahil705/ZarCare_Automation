namespace TestScripts
{

    public class HomePage : Base
    {

        public string classname = "HomePage";

        [Test]
        public void Validate_Redirection_To_OurProvider()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Our_Providers_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Validate the homepage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Our Provider Page");
            Home_Page.NavigateToOurProvider();
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Get_and_Validate_OurProvider_Title(Original_Title);
            Reports.FlushNode(Reports.childLog);


        }

        [Test]
        public void Validate_Redirection_To_AboutUs()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["About_Us_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Navigate to AboutUs Page");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to AboutUs Page");
            Home_Page.NavigateToAboutUs();
            AboutUs_Page.Get_and_Validate_AboutUs_Title(Original_Title);

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
        public void Validate_Redirection_To_Specialty_Card()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string SpecialtyName = json["Specialty_Name"].ToString();
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Navigate to Several Specialty Section");
            Home_Page.Validate_HomePage();
            Home_Page.ClickToSpecialtyCard();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Our Providers Page");
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Get_and_Validate_Doctor_Specialty(SpecialtyName);
            Reports.FlushNode(Reports.childLog);
        }
        [Test]
        public void Verify_Navigation_To_Video_Consult_Page()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Original_Title_Video_Consult"].ToString();
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Our Video Consult Page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToVideoConsultPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Search the Title of Video Consult Page");
            Video_Consult_Page.Get_and_Validate_Video_Consult_Page_Title(Original_Title);
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

        [Test]
        public void Validate_Redirection_To_Faq()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Faq_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Navigate to FAQ Page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToFaq();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Faq Page and validate the FAQ");
            Faq_Page.Validate_Faq();
            Faq_Page.Get_and_Validate_Faq_Title(Original_Title);
        }

        [Test]
        public void ValidateContactUsLink()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open and validate home page");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate & Navigate to Contact us page");
            Home_Page.NavigateToContactUs();
            ContactUs_Page.Validate_Contact_Us_Page();  
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void Verify_Redirection_To_OurProviders_Through_Connect_Now_Popup()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Our_Providers_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Connect Now Popup");
            Home_Page.NavigateToConnectNowPopup();
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Get_and_Validate_OurProviders_Title(Original_Title);
        }

        
        public void ConnectNow_Popup_Close()
        {
            var json = Json_Reader.GetDataFromJson(classname);

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Connect Now Popup");
            Home_Page.NavigateToConnectNowPopupClose();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void Verify_Redirection_On_Blog_Page()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["About_Us_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToBlogPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Zarcare Blog Page and validate the title");
            Blog_Page.Validate_BlogPage();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void Verify_Login_Page_Redirection()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Validate the homepage");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToLoginPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 1: Open Login Page and Validate the homepage");
            Login_Page.Validate_LoginPage();
            Reports.FlushNode(Reports.childLog);
        }
    }
}