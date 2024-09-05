namespace TestScripts
{
    public class FaqPage : Base
    {
        public string classname = "HomePage";

        [Test]
        public void Validate_Redirection_To_Faq()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Faq_Text"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Navigate to FAQ Page");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Faq Page");
            Home_Page.NavigateToFaq();
            Faq_Page.Validate_Faq();
            Faq_Page.Get_and_Validate_Faq_Title(Original_Title);
        }
    }
}
