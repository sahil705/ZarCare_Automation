namespace TestScripts
{
    public class ConnectNowPopup : Base
    {
        public string classname = "HomePage";

        [Test]
        public void ConnectNow_To_OurProviders()
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

        [Test]
        public void ConnectNow_Popup_Close()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Connect Now Popup");
            Home_Page.NavigateToConnectNowPopupClose();
        }
    }
}
