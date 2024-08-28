namespace TestScripts

{
    public class HomePage:Base
    {

        public string classname = "HomePage";

        [Test]
        public void Validate_Redirection_To_OurProvider()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Our_Provider_Title"].ToString();

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

    }
}
