using TestScripts;

namespace ZarCare_Automation.Test.PageActions
{
    public  class FamilyMember_Page : WebdriverSession
    {
       
        public static Home_Page_Locators Home_PageLoc = new Home_Page_Locators();
        public static Login_Page_Locator LoginPage = new Login_Page_Locator();
        public static Family_Member_page_Locator FamilyMemberPage = new Family_Member_page_Locator();
        public static Doctor_Profile_Page_Locators DoctorProfilePage = new Doctor_Profile_Page_Locators();

        public static void Enter_Patient_login_Detail(string EmailID, string password)
        {

            LoginPage.Web_Email_TextBox.SendKeys(EmailID);
            LoginPage.Web_Password_TextBox.SendKeys(password);

            LoginPage.Web_SignIn_Button.Click();
            Wait.WaitTillPageLoad();
            Wait.implicitWait(4);

            Reports.childLog.Log(Status.Info, "Login page is displayed");
            Generic_Utils.GetScreenshot("Login page screenshot");
        }

        public static void AddfamilyMemberDetail(string MemFirstName, string MemLastName, string MemWeight, string MemHeight, string MemGender, string Relation,string Country, string Province, string MemCity, string MemPinCode, string MemberAddress, string MemPhotoPath, string MemAddSuccMessage)
        {
            Wait.WaitTillPageLoad();

            // Dashboard page element
            Generic_Utils.IsElementDisplayed(FamilyMemberPage.By_DashboardHeader);

            FamilyMemberPage.Web_FamilyMemberTab.Click();
            Wait.WaitTillPageLoad();

            FamilyMemberPage.Web_AddMemberBtn.Click();
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(FamilyMemberPage.By_AddMemberPageheader);

            // Add member page element

            FamilyMemberPage.Web_MemberFirstName.SendKeys(MemFirstName);

            FamilyMemberPage.Web_MemberLastName.SendKeys(MemLastName);

            FamilyMemberPage.Web_MemberWeight.Clear();
            FamilyMemberPage.Web_MemberWeight.SendKeys(MemWeight);

            FamilyMemberPage.Web_MemberHeight.Clear();
            FamilyMemberPage.Web_MemberHeight.SendKeys(MemHeight);

            IWebElement FMemberGender = FamilyMemberPage.Web_GenderList;
            Generic_Utils.Dropdown_Handle_With_Text(FMemberGender, MemGender);

            IWebElement FMemberRalation = FamilyMemberPage.Web_RelationList;
            Generic_Utils.Dropdown_Handle_With_Value(FMemberRalation, Relation);

            FamilyMemberPage.Web_MemCountry.SendKeys(Country);

            FamilyMemberPage.Web_MemProvince.SendKeys(Province);

            FamilyMemberPage.Web_MemCity.SendKeys(MemCity);

            FamilyMemberPage.Web_MemPinCode.SendKeys(MemPinCode);

            FamilyMemberPage.Web_MemAddress.SendKeys(MemberAddress);
            Thread.Sleep(3000);
            try
            {
                string FilePath = @MemPhotoPath;

                FamilyMemberPage.Web_UploadPhoto.SendKeys(FilePath);
                Wait.WaitTillPageLoad();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured= {ex}");

            }

            FamilyMemberPage.Web_SubmitBtn.Click();
            Wait.WaitTillPageLoad();

           string actualAddMemberMessage = FamilyMemberPage.Web_ActualSuccessMessage.Text;
            Assert.AreEqual(MemAddSuccMessage, actualAddMemberMessage);

            Reports.childLog.Log(Status.Info, "Family Member added");
            Generic_Utils.GetScreenshot("Family Member screenshot");
            Wait.WaitTillPageLoad();
        }

        public static void AddedMemberDisplyInMembersPage(string AddedMemFirstName, string MemRelationshipText)
        {
            FamilyMemberPage.Web_FamilyMemberTab.Click();
            Wait.WaitTillPageLoad();
            int TotalMember = FamilyMemberPage.Web_MemFullName.Count;
            Console.WriteLine($"Total meme count={TotalMember}");

            for (int a = 0; a<TotalMember;a++)
            {
                string AddedMemFullName = FamilyMemberPage.Web_MemFullName[a].Text;
                
                if (AddedMemFullName.Contains(AddedMemFirstName))
                {
                    string AddedMemeberFullName = FamilyMemberPage.Web_MemFullName[a].Text;

                    string[] AddedMemFullNameSplit = AddedMemeberFullName.Split(' ');
                    string AddedMemberFname = AddedMemFullNameSplit[0];
                   
                    Assert.AreEqual(AddedMemFirstName, AddedMemberFname);
                    Generic_Utils.ScrollToBottom();
                    Reports.childLog.Log(Status.Info, "Added Family Member displyed");
                    Generic_Utils.GetScreenshot("Added Family Member displyed screenshot");
                    int relationcount = FamilyMemberPage.Web_RelationshipText.Count;
              
                    string RelationShipFullText = FamilyMemberPage.Web_RelationshipText[a].Text;
                    
                    bool isTextMatch = RelationShipFullText.Contains(MemRelationshipText, StringComparison.OrdinalIgnoreCase);

                    // Assert to validate  realtionship text
                    Assert.IsTrue(isTextMatch, $"The text '{RelationShipFullText}' does not contain '{MemRelationshipText}");
                    break;

                }
                else
                {
                    Console.WriteLine("No member name found into list");
                }
            }
        }

    }
}
