

namespace ZarCare_Automation.Test.PageValidations
{
    public  class FamilyMemberPageValidation
    {
        public static string MemberProfileJson = "FamilyMember";


        public static void AddFamilyMemberwithValiddata()
        {
            var json = Json_Reader.GetDataFromJson(MemberProfileJson);
            string EmailId = json["Email_id"].ToString();
            string PassWord = json["Password"].ToString();
            string MemFirstName = json["First_Name"].ToString();
            string MemLastName = json["Last_Name"].ToString();
            string MemWeight = json["Mem_Weight"].ToString();
            string MemHeight = json["Mem_Height"].ToString();
            string MemGender = json["Mem_Gender"].ToString();
            string MemRelation = json["Mem_Relation"].ToString();
            string MemCountry = json["Mem_Country"].ToString();
            string MemProvince = json["Mem_Province"].ToString();
            string MemCity = json["Mem_City"].ToString();
            string MemPinCode = json["Mem_PinCode"].ToString();
            string MemAddress = json["Mem_Address"].ToString();
            string MemPhotoPath = json["Mem_PhotoPath"].ToString();
            string MemAddSuccMessage = json["Mem_Add_Succ_Message"].ToString();
            string AddedMemRelation = json["Added_Mem_Relation"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Login Page");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(EmailId, PassWord);

            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate add family member deatil");
            FamilyMember_Page.AddfamilyMemberDetail(MemFirstName, MemLastName, MemWeight, MemHeight,MemGender, MemRelation, MemCountry, MemProvince, MemCity, MemPinCode, MemAddress, MemPhotoPath, MemAddSuccMessage);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Validate added member display in family member page");
            FamilyMember_Page.AddedMemberDisplyInMembersPage(MemFirstName, AddedMemRelation);
            Reports.FlushNode(Reports.childLog);




        }
    }
}
