namespace TestScripts
{
    public class SpecialtyCard : Base
    {
        public string classname = "HomePage";



        [Test]
        public void Validate_Redirection_To_Specialty_Card()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string SpecialtyName = json["Specialty_Name"].ToString();
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Navigate to Several Specialty Section");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Our Providers Page");
            Home_Page.NavigateToSpecialtyCard();
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Get_and_Validate_Doctor_Specialty(SpecialtyName);       
        }
    }
}
