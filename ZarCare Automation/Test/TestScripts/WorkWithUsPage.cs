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
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Navigate to WorkWithUs Page and validate fileds");
            Home_Page.NavigateToWorkWithUs();
            Work_With_Us_Page.Validate_WorkWithUs();
            Work_With_Us_Page.Get_and_Validate_WorkWithUs_Text(Original_Title);
          

            Work_With_Us_Page.NavigateToSubmitButton();
            Work_With_Us_Page.Get_and_Validate_FirstName_Error(FirstNameError);
            Work_With_Us_Page.Get_and_Validate_SurName_Error(SurNameError);
            Work_With_Us_Page.Get_and_Validate_Web_CellPhone_Error(CellPhoneError);
            Work_With_Us_Page.Get_and_Validate_Email_Error(EmailError);
            Work_With_Us_Page.Get_and_Validate_Profession_Error(ProfessionError);
            Work_With_Us_Page.Get_and_Validate_Province_Error(ProvinceError);
            Work_With_Us_Page.Get_and_Validate_City_Error(CityError);
            Work_With_Us_Page.Get_and_Validate_Current_WorkPlace_Error(WorkPlaceError);
            Reports.FlushNode(Reports.childLog);


        }
    }
}
