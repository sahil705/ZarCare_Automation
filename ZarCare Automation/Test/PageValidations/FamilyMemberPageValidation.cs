

namespace ZarCare_Automation.Test.PageValidations
{
    public  class FamilyMemberPageValidation
    {
        public static string MemberProfileJson = "FamilyMember";
        public static string LoginJson = "Login";

         

        public static void AddFamilyMemberwithValiddata()
        {
            var Fmemebrjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "FamilyMembeDetail");
            var loginjson = Json_Reader.GetDataFromJson(LoginJson);

            string EmailId = loginjson["Email"].ToString();
            string PassWord = loginjson["Password"].ToString();
            string MemberFirstName = Fmemebrjson[0]["First_Name"].ToString();
            string MemberLastName = Fmemebrjson[1]["Last_Name"].ToString();
            string MemberWeight = Fmemebrjson[2]["Mem_Weight"].ToString();
            string MemberHeight = Fmemebrjson[3]["Mem_Height"].ToString();
            string MemberGender = Fmemebrjson[4]["Mem_Gender"].ToString();
            string MemberRelation = Fmemebrjson[5]["Mem_Relation"].ToString();
            string MemberCountry = Fmemebrjson[6]["Mem_Country"].ToString();
            string MemberProvince = Fmemebrjson[7]["Mem_Province"].ToString();
            string MemberCity = Fmemebrjson[8]["Mem_City"].ToString();
            string MemberPinCode = Fmemebrjson[9]["Mem_PinCode"].ToString();
            string MemberAddress = Fmemebrjson[10]["Mem_Address"].ToString();
            string MemberPhotoPath = Fmemebrjson[11]["Mem_PhotoPath"].ToString();
            string MemberAddSuccMessage = Fmemebrjson[12]["Mem_Add_Succ_Message"].ToString();
            string AddedMemberRelation = Fmemebrjson[13]["Added_Mem_Relation"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Login Page");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(EmailId, PassWord);

            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate add family member detail");
            FamilyMember_Page.AddfamilyMemberDetail(MemberFirstName, MemberLastName, MemberWeight, MemberHeight,MemberGender, MemberRelation, MemberCountry, MemberProvince, MemberCity, MemberPinCode, MemberAddress, MemberPhotoPath, MemberAddSuccMessage);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Validate added member display in family member page");
            FamilyMember_Page.AddedMemberDisplyInMembersPage(MemberFirstName, AddedMemberRelation);
            Reports.FlushNode(Reports.childLog);
        }
        public static void ValidateMandatoryFieldForFamilyMember()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            var Fmemebrjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "MemberValiMessages");
            var loginjson = Json_Reader.GetDataFromJson(LoginJson);

            string EmailId = loginjson["Email"].ToString();
            string PassWord = loginjson["Password"].ToString();
            string FirstNameRequiredErrorMessage = Fmemebrjson[0]["Mem_First_name_Req_Error_message"].ToString();
            string LastNameRequiredErrorMessage = Fmemebrjson[1]["Mem_Last_name_Req_Error_message"].ToString();
            string MemWeightRequiredErrorMessage = Fmemebrjson[2]["Mem_Weight_RequiredErrorMessage"].ToString();
            string MemHeightRequiredErrorMessage = Fmemebrjson[3]["Mem_Height_ReqErrorMessage"].ToString();


            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Login Page");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(EmailId, PassWord);
           
            Reports.childLog = Reports.CreateNode("Step 2: Validate Mandatory field Required for family member ");
            FamilyMember_Page.AddFamilyMemberWithoutMandatoryField(FirstNameRequiredErrorMessage, LastNameRequiredErrorMessage, MemWeightRequiredErrorMessage, MemHeightRequiredErrorMessage);
        }

        public static void AddedMemberDisplayInMedilcalfile()
        {
            var Fmemberjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "FamilyMembeDetail");
            var json = Json_Reader.GetDataFromJson(MemberProfileJson);
           
            string MemberFirstName = Fmemberjson[0]["First_Name"].ToString();
            string MemberRelationText = json["Mem_Relationship_text"].ToString();
                     
            Reports.childLog = Reports.CreateNode("Step 1: Validate Added Member display in medical File");
            FamilyMember_Page.AddedMemberDisplayedInMedicalFile(MemberFirstName, MemberRelationText);

        }
        public  static void AddedMemberDisplayedInFamilyMemberDropDown()
        {
            
            var Fmemberjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "FamilyMembeDetail");
            var json = Json_Reader.GetDataFromJson(MemberProfileJson);
            
            string MemberFirstName = Fmemberjson[0]["First_Name"].ToString();
            string MemberLastName = Fmemberjson[1]["Last_Name"].ToString();
            string MemberRelationText = json["Mem_Relationship_text"].ToString();
            string AppointMentTime = json["Appointment_Time"].ToString();
            string MemberFinalName = MemberFirstName + " " + MemberLastName + "(" + MemberRelationText + ")";
          
            Reports.childLog = Reports.CreateNode("Step 1: Validate added family member into Member's Dropdown");
            FamilyMember_Page.AddedmemberAppearInMemberDropdown(AppointMentTime, MemberFinalName);

        }

    }
}
