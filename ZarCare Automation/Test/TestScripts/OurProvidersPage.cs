namespace TestScripts
{

    public class OurProvidersPage : Base
    
    {
        Appointment app = new Appointment();
        public string classname = "OurProvider";
        public string appointmentDetail = "BookAppointments";

        [Test]
        public void Validate_OurProviders_By_Name()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string doctorName = json["Doctor_Name"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate HomePage and Navigate to OurProvidersPage");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToOurProvider();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Search by Doctor Name");
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Search_Doctor(doctorName);
            Our_Providers_Page.Get_and_Validate_Doctor_Name(doctorName);
            Reports.FlushNode(Reports.childLog);

            Our_Providers_Page.NavigateToCloseButton();
        }

        [Test]
        public void Validate_OurProviders_By_Category()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string doctorSpecialty = json["Doctor_Specialty"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate HomePage and Navigate to OurProvidersPage");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToOurProvider();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Search by Doctor Specialty");
            Our_Providers_Page.Search_Category(doctorSpecialty);
            Our_Providers_Page.Get_and_Validate_Doctor_Specialty(doctorSpecialty);
            Our_Providers_Page.NavigateToCloseButton();
            Reports.FlushNode(Reports.childLog);  
        }

        [Test]
        public void Validate_OurProviders_By_Location()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string doctorLocation = json["Doctor_Location"].ToString();
            string getLocation = json["Get_Doctor_Location"].ToString();
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate HomePage and Navigate to OurProvidersPage");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToOurProvider();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Search by Doctor Location");
            Our_Providers_Page.Search_Location(doctorLocation);
            Our_Providers_Page.Get_and_Validate_Doctor_Location(getLocation);    
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void Verify_And_Clear_Doctors_Category()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string doc_category = json["doc_category"].ToString();
            string Original_Category_Title = json["OriginalCategoryTitle"].ToString();
            string Top_Category_Title = json["Doctor_Top_Category"].ToString();
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Our Providesr Page.");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToOurProvider();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate Our Providers Page and validate on the specific category");
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.ValidateAllCategory_And_Click_Category(doc_category);
            Our_Providers_Page.ValidateSelectedCategory(Original_Category_Title);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Clear the category and validate the top category ");
            //Our_Providers_Page.RemoveCategory();
            //Our_Providers_Page.Validate_Top_Category(Top_Category_Title);
            Reports.FlushNode(Reports.childLog);

         }

        [Test]
        public void Verify_Register_Page_Title_Through_Doctor_Profile()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string doctorName = json["Doctor_Name"].ToString();
            string appointmentDate = json["Appointment_Date"].ToString();
            string appointmentTime = json["Appointment_Time"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Our Provider Page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToConsultNow();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Search doctor");
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Search_Doctor(doctorName);
            Our_Providers_Page.FetchDoctorFromList(doctorName);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Validate Doctor Profile and Book Appointment");
            Doctor_Profile_Page.ValidateDoctorProfile();
            Doctor_Profile_Page.BookAppointment(appointmentDate, appointmentTime);
            Register_Page.Validate_RegisterPage();
            Reports.FlushNode(Reports.childLog);

        }

        [Test]
        public void ValidateRegisterPageThroughBookAppButtonOnOurProviderPage()
        {
            var json = Json_Reader.GetDataFromJson(appointmentDetail);
            string Doctorsname = json["Doctor_Name"].ToString();
            string Appoint_Date = json["Appointment_Date"].ToString();
            string Appointment_time = json["Appointment_Time"].ToString();


            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open and validate home page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToOurProvider();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate & Navigate to our provider page");
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.ClickOnBookAppointmentButton(Doctorsname);
            Our_Providers_Page.ClickOnProviderSlotAndNavigateToRegisterPage(Appoint_Date, Appointment_time);
            Register_Page.Validate_RegisterPage();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void ValidateAppointmentSlotWithTotalCountOnOurProviderPage()
        {
            var json = Json_Reader.GetDataFromJson(appointmentDetail);
            string Doctorsname = json["Doctor_Name"].ToString();
            string Appoint_Date = json["Appointment_Date"].ToString();
            
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open and validate home page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToOurProvider();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate & Navigate to our provider page and Validate slot count");
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.ClickOnBookAppointmentButton(Doctorsname);
            Our_Providers_Page.GetSlotCountAndValidateWithTotalCount(Appoint_Date);
            Reports.FlushNode(Reports.childLog);

        }

            [Test]
        public void Verify_Slot_Visible_On_OurProvider_Page_After_Cancellation()
        {
            var appointment = Json_Reader.GetDataFromJson(appointmentDetail);
            string email = appointment["Email"].ToString();
            string password = appointment["Password"].ToString();
            string providerName = appointment["Doctor_Name"].ToString();
            string appointmentDate = appointment["Appointment_Date"].ToString();
            string appointmentTime = appointment["Appointment_Time"].ToString();
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Our Provider Page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToLoginPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate the login page and Patient Login into the website");
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(email, password);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Navigate the Patient Profile page and Validate the page");
            Patient_Profile_Page.ValidatePatientProfile();
            Patient_Profile_Page.NavigateToActiveAppointment();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 4: Navigate the Active Appointment page and Validate the page");
            ActiveAppointment_Page.Validate_Active_Appointment_Page();
            ActiveAppointment_Page.NavigateToViewDetailPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 4: Navigate the View Detail page and Appointment Cancellation");
            ViewDetail_Page.Validate_ViewDetailPage();
            ViewDetail_Page.CancelAppointment();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 5: Navigate the Our Provider page and Search Provider");
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Search_Doctor(providerName);
            Our_Providers_Page.FetchDoctorFromList(providerName);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 6: Navigate the Doctor Profile page and check slot visible");
            Doctor_Profile_Page.ValidateDoctorProfile();
            Doctor_Profile_Page.Verify_Slot_Availability_On_Doctor_Profile(appointmentDate, appointmentTime);
            Reports.FlushNode(Reports.childLog);

        }

    }
}
