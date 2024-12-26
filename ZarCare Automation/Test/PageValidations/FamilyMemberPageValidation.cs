using System.Diagnostics.Metrics;

namespace ZarCare_Automation.Test.PageValidations
{
    public  class FamilyMemberPageValidation
    {
        public static string MemberProfileJson = "FamilyMember";
        public static string LoginJson = "Login";

         

        public static void AddFamilyMemberwithValiddata()
        {
            var Fmemebrjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "FamilyMembeDetail");
            //var json = Json_Reader.GetDataFromJson(MemberProfileJson);
            var loginjson = Json_Reader.GetDataFromJson(LoginJson);
            string EmailId = loginjson["Email"].ToString();
            string PassWord = loginjson["Password"].ToString();
            string MemFirstName = Fmemebrjson[0]["First_Name"].ToString();
            string MemLastName = Fmemebrjson[1]["Last_Name"].ToString();
            string MemWeight = Fmemebrjson[2]["Mem_Weight"].ToString();
            string MemHeight = Fmemebrjson[3]["Mem_Height"].ToString();
            string MemGender = Fmemebrjson[4]["Mem_Gender"].ToString();
            string MemRelation = Fmemebrjson[5]["Mem_Relation"].ToString();
            string MemCountry = Fmemebrjson[6]["Mem_Country"].ToString();
            string MemProvince = Fmemebrjson[7]["Mem_Province"].ToString();
            string MemCity = Fmemebrjson[8]["Mem_City"].ToString();
            string MemPinCode = Fmemebrjson[9]["Mem_PinCode"].ToString();
            string MemAddress = Fmemebrjson[10]["Mem_Address"].ToString();
            string MemPhotoPath = Fmemebrjson[11]["Mem_PhotoPath"].ToString();
            string MemAddSuccMessage = Fmemebrjson[12]["Mem_Add_Succ_Message"].ToString();
            string AddedMemRelation = Fmemebrjson[13]["Added_Mem_Relation"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Login Page");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(EmailId,PassWord);
           
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate add family member detail");
            FamilyMember_Page.AddfamilyMemberDetail(MemFirstName, MemLastName, MemWeight, MemHeight,MemGender, MemRelation, MemCountry, MemProvince, MemCity, MemPinCode, MemAddress, MemPhotoPath, MemAddSuccMessage);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Validate added member display in family member page");
            FamilyMember_Page.AddedMemberDisplyInMembersPage(MemFirstName, AddedMemRelation);
            Reports.FlushNode(Reports.childLog);
        }
        public static void ValidateMandatoryFielddForFamilyMember()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            var Fmemebrjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "MemberValiMessages");
            //var json = Json_Reader.GetDataFromJson(MemberProfileJson);
            var loginjson = Json_Reader.GetDataFromJson(LoginJson);
            string EmailId = loginjson["Email"].ToString();
            string PassWord = loginjson["Password"].ToString();
            string FirstNameReqErrorMessage = Fmemebrjson[0]["Mem_First_name_Req_Error_message"].ToString();
            string LastNameReqErrorMessage = Fmemebrjson[1]["Mem_Last_name_Req_Error_message"].ToString();
            string MemWeightReqErrorMessage = Fmemebrjson[2]["Mem_Weight_RequiredErrorMessage"].ToString();
            string MemHeightReqErrorMessage = Fmemebrjson[3]["Mem_Height_ReqErrorMessage"].ToString();


            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Login Page");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(EmailId, PassWord);
           
            Reports.childLog = Reports.CreateNode("Step 2: Validate Mandatory field Required for family member ");
            FamilyMember_Page.AddFamilyMemberWithoutMandatoryField(FirstNameReqErrorMessage, LastNameReqErrorMessage, MemWeightReqErrorMessage, MemHeightReqErrorMessage);
        }

        public static void AddedMemberDisplayInMedilcalfile()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            var Fmemberjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "FamilyMembeDetail");
            var json = Json_Reader.GetDataFromJson(MemberProfileJson);
            var loginjson = Json_Reader.GetDataFromJson(LoginJson);
            string EmailId = loginjson["Email"].ToString();
            string PassWord = loginjson["Password"].ToString();
            string MemFirstName = Fmemberjson[0]["First_Name"].ToString();
            string MemRelationText = json["Mem_Relationship_text"].ToString();

            Reports.childLog = Reports.CreateNode("Step 1: Validate Login into Application");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(EmailId, PassWord);
            //FamilyMember_Page.Enter_Patient_login_Detail(EmailId, PassWord);

            Reports.childLog = Reports.CreateNode("Step 2: Validate Added Member display in medical File");
            FamilyMember_Page.AddedMemberDisplayedInMedicalFile(MemFirstName, MemRelationText);

        }
        public  static void AddedMemberDisplayedInFamilyMemberDropDown()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            var Fmemberjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "FamilyMembeDetail");
            var json = Json_Reader.GetDataFromJson(MemberProfileJson);
            var loginjson = Json_Reader.GetDataFromJson(LoginJson);
            string EmailId = loginjson["Email"].ToString();
            string PassWord = loginjson["Password"].ToString();
            string MemFirstName = Fmemberjson[0]["First_Name"].ToString();
            string MemLastName = Fmemberjson[1]["Last_Name"].ToString();
            string MemRelationText = json["Mem_Relationship_text"].ToString();
            string AppointMentTime = json["Appointment_Time"].ToString();
            string MemberFinal = MemFirstName + " " + MemLastName + "(" + MemRelationText + ")";

            Reports.childLog = Reports.CreateNode("Step 1: Validate Login into Application");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(EmailId, PassWord);
            //FamilyMember_Page.Enter_Patient_login_Detail(EmailId, PassWord);

            Reports.childLog = Reports.CreateNode("Step 2: Validate Book optment and navigate to Opptnment page");
            FamilyMember_Page.AddedmemberAppearInMemberDropdown(AppointMentTime, MemberFinal);

        }

    }
}
