namespace ZarCare_Automation.Test.TestScripts
{
    public class WorkWithUs : Base
    {
        public string classname = "WorkWithUs";

        [Test]
        public void Check_Database_For_Duplicate_Email()
        {

            var workWithUsJson = Json_Reader.GetDataFromJson(classname);

            string firstName = workWithUsJson["First_Name"].ToString();
            string surName = workWithUsJson["Sur_Name"].ToString();
            string cellPhone = workWithUsJson["Cellphone_Number"].ToString();
            string email = workWithUsJson["Email"].ToString();
            string professionValue = workWithUsJson["Profession_Description"].ToString();
            string provinceValue = workWithUsJson["Province"].ToString();
            string city = workWithUsJson["City"].ToString();
            string serviceValue = workWithUsJson["Service_Area"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to WorkWithUs Page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToWorkWithUsPage();
            Reports.FlushNode(Reports.childLog); 

            Reports.childLog = Reports.CreateNode("Step 2: Validate Work with us page and Filling the work with us form");
            WorkWithUs_Page.Validate_WorkWithUs();
            WorkWithUs_Page.WorkWithUs_Form_Submission(firstName, surName, cellPhone, email, professionValue, provinceValue, city, serviceValue);

        public void Work_With_Us_Test()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string WorkWithUsErrorMessage = json["WorkWithUsErrorMessage"].ToString();
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1 : Validate Home Page and navigate to Work With Us page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToWorkWithUsPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2 : Validate Work With Us Page");
            Work_With_Us.ValidateWorkWithUsPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3 : Fill the complete Form and Click Submit Button");
            Work_With_Us.FillWorkWIthUsForm();
            Work_With_Us.SubmitButton();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 4: Verify the error message");
            Work_With_Us.Get_And_Validate_ErrorMessage_WorkWithUs(WorkWithUsErrorMessage);
            Reports.FlushNode(Reports.childLog);
        }
    }
}
