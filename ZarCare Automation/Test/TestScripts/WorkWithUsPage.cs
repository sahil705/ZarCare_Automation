namespace TestScripts
{
    public class WorkWithUsPage : Base
    {
        public string classname = "WorkWithUs";

        [Test]
        public void Validate_Redirection_To_WorkWithUs()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["WorkWithUs_Heading"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Navigate to WorkWithUs Page");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to WorkWithUs Page");
            Home_Page.NavigateToWorkWithUs();
            Work_With_Us_Page.Validate_WorkWithUs();
            Work_With_Us_Page.Get_and_Validate_WorkWithUs_Text(Original_Title);

            //Reports.childLog = Reports.CreateNode("Step 3: Validate all fields after submit");
            //Work_With_Us_Page.NavigateToSubmitButton();

        }
    }
}
