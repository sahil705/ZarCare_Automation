namespace ZarCare_Automation.Test.PageValidations
{
    public class HomePageValidation
    {
        public static string classname = "HomePage";

        public static void Validate_Redirection_To_OurProvider()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Our_Providers_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Redirection To OurProvider Page");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Our Provider Page");
            Home_Page.NavigateToOurProvider();
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Get_and_Validate_OurProvider_Title(Original_Title);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void Validate_Redirection_To_AboutUs()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["About_Us_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Redirection To AboutUs");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "Step 2: Validate the AboutUs Page");
            Home_Page.NavigateToAboutUs();
            AboutUs_Page.Get_and_Validate_AboutUs_Title(Original_Title);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void Validate_SpecialtyCard_Redirection_To_OurProvider()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string SpecialtyName = json["Specialty_Name"].ToString();
            
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Verify SpecialtyCard Redirection To Our Provider Page");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "Step 2:Validate Specific Category list Opens in Our Providers Page");
            Home_Page.ClickToSpecialtyCard();   
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Get_and_Validate_Doctor_Specialty(SpecialtyName);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void Verify_Redirection_To_Video_Consult_Page()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Original_Title_Video_Consult"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Redirection To Video Consult Page");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Video Consult Page");
            Home_Page.NavigateToVideoConsultPage();
            Video_Consult_Page.Get_and_Validate_Video_Consult_Page_Title(Original_Title);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "=================================================");

        }

        public static void Validate_Redirection_To_Faq()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Faq_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Redirection To FAQ Page");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "Step 2: Validate the FAQ Page");
            Home_Page.NavigateToFaq();
            Faq_Page.Validate_Faq();
            Faq_Page.Get_and_Validate_Faq_Title(Original_Title);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void Validate_Redirection_To_Login_Page()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Redirection To Login Page");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "=================================================");

        }

        public static void Validate_Redirection_To_WorkWithUs_Page()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Redirection To Work With Us Page");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Work With Us Page");
            Home_Page.NavigateToWorkWithUsPage();
            WorkWithUs_Page.Validate_WorkWithUs();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void Validate_Redirection_To_Blog_Page()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["About_Us_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Redirection To Blog Page");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Blog Page");
            Home_Page.NavigateToBlogPage();
            Blog_Page.Validate_BlogPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void Validate_Redirection_To_ContactUs_Page()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Redirection To ContactUs Page");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "Step 2: Validate the ContactUs Page");
            Home_Page.NavigateToContactUs();
            ContactUs_Page.Validate_Contact_Us_Page();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void Verify_ConnectNowPopup_Redirection_To_OurProviders()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Our_Providers_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, "Validate Redirection To OurProvider Page Through Connect Now Popup");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Our Provider Page");
            Home_Page.NavigateToConnectNowPopup();
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Get_and_Validate_OurProviders_Title(Original_Title);
            Reports.FlushNode(Reports.childLog);
        }
    }
}
