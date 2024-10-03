using ZarCare_Automation.Test.PageActions;

namespace TestScripts

{
    public class WorkWithUs : Base
    {
        public string classname = "WorkWithUs";

        [Test]
        public void Verify_Work_With_Us_Form_Submission()
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
            string successMessage = workWithUsJson["Success_Message"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to WorkWithUs Page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToWorkWithUsPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate Work with us page and Filling the work with us form");
            WorkWithUs_Page.Validate_WorkWithUs();
            WorkWithUs_Page.WorkWithUs_Form_Submission_With_New_Data(firstName, surName, cellPhone, email, professionValue, provinceValue, city, serviceValue);
            WorkWithUs_Page.Get_and_Validate_WorkWithUs_Success_Message(successMessage);
            Reports.FlushNode(Reports.childLog);
        }

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
            WorkWithUs_Page.WorkWithUs_Form_Submission_With_New_Data(firstName, surName, cellPhone, email, professionValue, provinceValue, city, serviceValue);
            WorkWithUs_Page.Check_Duplicate_Email_From_Database(email);
            Reports.FlushNode(Reports.childLog);
        }
        
        [Test]
        public void Check_Existing_User_Validation_On_Work_With_Us_Form ()
        {

            var workWithUsJson = Json_Reader.GetDataFromJson(classname);
            string firstName = workWithUsJson["First_Name"].ToString();
            string surName = workWithUsJson["Sur_Name"].ToString();
            string cellPhone = workWithUsJson["Existing_Cell"].ToString();
            string email = workWithUsJson["Existing_Email"].ToString();
            string professionValue = workWithUsJson["Profession_Description"].ToString();
            string provinceValue = workWithUsJson["Province"].ToString();
            string city = workWithUsJson["City"].ToString();
            string serviceValue = workWithUsJson["Service_Area"].ToString();
            string WorkWithUsErrorMessage = workWithUsJson["WorkWithUsErrorMessage"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1 : Validate Home Page and navigate to Work With Us page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToWorkWithUsPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2 : Validate Work With Us Page");
            WorkWithUs_Page.Validate_WorkWithUs();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3 : Fill the complete Form and Verify validations");
            WorkWithUs_Page.WorkWithUs_Form_Submission_With_Existing_Data(firstName, surName, cellPhone, email, professionValue, provinceValue, city, serviceValue);
            WorkWithUs_Page.Get_And_Validate_ErrorMessage_WorkWithUs(WorkWithUsErrorMessage);
            Reports.FlushNode(Reports.childLog);
        }
        
        [Test]
        public void Check_Required_Validation_In_WorkWithUs()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            
            string FirstNameError = json["FirstName_Error"].ToString();
            string SurNameError = json["SurName_Error"].ToString();
            string CellPhoneError = json["CellPhone_Error"].ToString();
            string EmailError = json["Email_Error"].ToString();
            string ProfessionError = json["Profession_Error"].ToString();
            string ProvinceError = json["Province_Error"].ToString();
            string CityError = json["City_Error"].ToString();
            string WorkPlaceError = json["WorkPlace_Error"].ToString();


            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open Home Page and Navigate to WorkWithUs Page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToWorkWithUsPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to WorkWithUs Page and validate fileds");
            WorkWithUs_Page.Validate_WorkWithUs();
            WorkWithUs_Page.ClickToSubmitButton();
            WorkWithUs_Page.Get_and_Validate_FirstName_Error(FirstNameError);
            WorkWithUs_Page.Get_and_Validate_SurName_Error(SurNameError);
            WorkWithUs_Page.Get_and_Validate_Web_CellPhone_Error(CellPhoneError);
            WorkWithUs_Page.Get_and_Validate_Email_Error(EmailError);
            WorkWithUs_Page.Get_and_Validate_Profession_Error(ProfessionError);
            WorkWithUs_Page.Get_and_Validate_Province_Error(ProvinceError);
            WorkWithUs_Page.Get_and_Validate_City_Error(CityError);
            WorkWithUs_Page.Get_and_Validate_Current_WorkPlace_Error(WorkPlaceError);
            Reports.FlushNode(Reports.childLog);
        }
    }
}
