namespace TestScripts
{
    public class OurProvidersPage : Base
    {
        public string classname = "OurProviders";

        [Test]
        public void Validate_OurProviders_By_Name()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string doctorName = json["Doctor_Name"].ToString();
                       
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate HomePage and Navigate to OurProvidersPage");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToOurProviders();
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
            Home_Page.NavigateToOurProviders();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Search by Doctor Specialty");

            Our_Providers_Page.Search_Category(doctorSpecialty);
            Our_Providers_Page.Get_and_Validate_Doctor_Specialty(doctorSpecialty);
            Reports.FlushNode(Reports.childLog);

            Our_Providers_Page.NavigateToCloseButton();
        }

        [Test]
        public void Validate_OurProvider_By_Location()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string doctorLocation = json["Doctor_Location"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate HomePage and Navigate to OurProvidersPage");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToOurProviders();
            Reports.FlushNode(Reports.childLog);


            Reports.childLog = Reports.CreateNode("Step 2: Search by Doctor Location");
            Our_Providers_Page.Search_Location(doctorLocation);
            Our_Providers_Page.Get_and_Validate_Doctor_Location(doctorLocation);
            Reports.FlushNode(Reports.childLog);
        }
    }
}
