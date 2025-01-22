namespace ZarCare_Automation.Test.PageValidations
{
    public  class FamilyMemberPageValidation
    {
        public static string MemberProfileJson = "FamilyMember";
        public static string Login = "LoginData";

        public static void SubmitFamilyMember()
        {
            var Fmemebrjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "FamilyMembeDetail");
            var loginJson = Json_Reader.GetArrayFromJson(Login, "ValidLoginData");

            string userEmail = loginJson[0]["Login_Patient_Email"].ToString();
            string userPassword = loginJson[0]["Login_Patient_Password"].ToString();
            string userCell = loginJson[0]["Patient_CellPhone"].ToString();
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

            Reports.childLog.Log(Status.Info, " Family Member Form Submission ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page and Patient Login ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(userEmail, userPassword);

            Reports.childLog.Log(Status.Info, "Step 3: Check the Email and Cellphone Status ");
            bool status = Login_Page.Get_EmailAndCellPhone_Status(userEmail, userCell);
            if (status == true)
            {
                Reports.childLog.Log(Status.Info, "Step 3: Submit Family Member Detail and Validate the Added Member in Family Member Page ");
                Patient_Dashboard_Page.ValidatePatientDashboard();
                Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
                FamilyMember_Page.AddfamilyMemberDetail(MemFirstName, MemLastName, MemWeight, MemHeight, MemGender, MemRelation, MemCountry, MemProvince, MemCity, MemPinCode, MemAddress, MemPhotoPath, MemAddSuccMessage);
                FamilyMember_Page.AddedMemberDisplyInMembersPage(MemFirstName, AddedMemRelation);
            }
            else
            {
                Reports.childLog.Log(Status.Info, "Step 4: Redirects to Email and Cellphone Verification Page");
                Patient_Dashboard_Page.ValidateUnverifiedDashboard();
                Patient_Dashboard_Page.userLogout();
            }

            Reports.childLog.Log(Status.Info, "=================================================");

        }
        public static void ValidateMandatoryFieldForFamilyMember()
        {
           

            var Fmemebrjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "MemberValiMessages");
            var loginJson = Json_Reader.GetArrayFromJson(Login, "ValidLoginData");

            string userEmail = loginJson[0]["Login_Patient_Email"].ToString();
            string userPassword = loginJson[0]["Login_Patient_Password"].ToString();
            string userCell = loginJson[0]["Patient_CellPhone"].ToString();
            string FirstNameReqErrorMessage = Fmemebrjson[0]["Mem_First_name_Req_Error_message"].ToString();
            string LastNameReqErrorMessage = Fmemebrjson[1]["Mem_Last_name_Req_Error_message"].ToString();
            string MemWeightReqErrorMessage = Fmemebrjson[2]["Mem_Weight_RequiredErrorMessage"].ToString();
            string MemHeightReqErrorMessage = Fmemebrjson[3]["Mem_Height_ReqErrorMessage"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog.Log(Status.Info, " Validate the Mandatory Fields in Family Member Form ");

            Reports.childLog.Log(Status.Info, "Step 1: Validate the HomePage");
            Home_Page.Validate_HomePage();

            Reports.childLog.Log(Status.Info, "Step 2: Validate the Login Page and Patient Login ");
            Home_Page.NavigateToLoginPage();
            Login_Page.Validate_LoginPage();
            Login_Page.Patient_Login(userEmail, userPassword);

            Reports.childLog.Log(Status.Info, "Step 3: Check the Email and Cellphone Status ");
            bool status = Login_Page.Get_EmailAndCellPhone_Status(userEmail, userCell);
            if (status == true)
            {
                Reports.childLog.Log(Status.Info, "Step 4: Validate the Required Fields ");
                Patient_Dashboard_Page.ValidatePatientDashboard();
                Patient_Dashboard_Page.HandleNotificationPopupOnDashboard();
                FamilyMember_Page.AddFamilyMemberWithoutMandatoryField(FirstNameReqErrorMessage, LastNameReqErrorMessage, MemWeightReqErrorMessage, MemHeightReqErrorMessage);
            }
            else
            {
                Reports.childLog.Log(Status.Info, "Step 4: Redirects to Email and Cellphone Verification Page");
                Patient_Dashboard_Page.ValidateUnverifiedDashboard();
                Patient_Dashboard_Page.userLogout();
            }

            Reports.childLog.Log(Status.Info, "=================================================");
        }

        public static void AddedMemberDisplayInMedicalFile()
        {
     
            var Fmemberjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "FamilyMembeDetail");
            var json = Json_Reader.GetDataFromJson(MemberProfileJson);  
            string MemFirstName = Fmemberjson[0]["First_Name"].ToString();
            string MemRelationText = json["Mem_Relationship_text"].ToString();

            Reports.childLog = Reports.CreateNode("Step 1: Validate Added Member display in medical File");
            FamilyMember_Page.AddedMemberDisplayedInMedicalFile(MemFirstName, MemRelationText);

        }
        public  static void AddedMemberDisplayedInFamilyMemberDropDown()
        {
 
            var Fmemberjson = Json_Reader.GetArrayFromJson(MemberProfileJson, "FamilyMembeDetail");
            var json = Json_Reader.GetDataFromJson(MemberProfileJson);
            
            string MemFirstName = Fmemberjson[0]["First_Name"].ToString();
            string MemLastName = Fmemberjson[1]["Last_Name"].ToString();
            string MemRelationText = json["Mem_Relationship_text"].ToString();
            string AppointMentTime = json["Appointment_Time"].ToString();
            string MemberFinal = MemFirstName + " " + MemLastName + "(" + MemRelationText + ")";
 
            Reports.childLog = Reports.CreateNode("Step 1: Validate added family member into Member's Dropdown");
            FamilyMember_Page.AddedmemberAppearInMemberDropdown(AppointMentTime, MemberFinal);

        }

    }
}
