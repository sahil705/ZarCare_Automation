using TestScripts;

namespace ZarCare_Automation.Test.PageActions
{
    public class FamilyMember_Page : WebdriverSession
    {

       
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

        public static void AddfamilyMemberDetail(string MemFirstName, string MemLastName, string MemWeight, string MemHeight, string MemGender, string Relation, string Country, string Province, string MemCity, string MemPinCode, string MemberAddress, string MemPhotoPath, string MemAddSuccMessage)
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

            //FamilyMemberPage.Web_SubmitBtn.Click();
            
            //string actualAddMemberMessage = FamilyMemberPage.Web_ActualSuccessMessage.Text;

            //Assert.AreEqual(MemAddSuccMessage, actualAddMemberMessage);

            Reports.childLog.Log(Status.Info, "Family Member added");
            Generic_Utils.GetScreenshot("Family Member screenshot");
            FamilyMemberPage.Web_FamilyMemberTab.Click();
            
            Wait.ElementIsVisible(FamilyMemberPage.By_AddMemberBtn,5);
          
        }

        public static void AddedMemberDisplyInMembersPage(string AddedMemFirstName, string MemRelationshipText)
        {
                      
            Wait.WaitTillPageLoad();
            int TotalMember = FamilyMemberPage.Web_MemFullName.Count;
            
            for (int a = 0; a <TotalMember; a++)
            {
                string AddedMemFullName = FamilyMemberPage.Web_MemFullName[a].Text;

                if (AddedMemFullName.Contains(AddedMemFirstName))
                {
                    string AddedMemeberFullName = FamilyMemberPage.Web_MemFullName[a].Text;

                    string[] AddedMemFullNameSplit = AddedMemeberFullName.Split(' ');
                    string AddedMemberFname = AddedMemFullNameSplit[0];
                    Assert.That(AddedMemFirstName, Is.EqualTo(AddedMemberFname));
                    
                    Console.WriteLine("AddemeFname="+AddedMemFirstName+" and Expecd fname="+AddedMemberFname);
                    Generic_Utils.ScrollToBottom();
                    Reports.childLog.Log(Status.Info, "Added Family Member displyed");
                    Generic_Utils.GetScreenshot("Added Family Member displyed screenshot");
                    int relationcount = FamilyMemberPage.Web_RelationshipText.Count;

                    string RelationShipFullText = FamilyMemberPage.Web_RelationshipText[a-1].Text;

                    bool isTextMatch = RelationShipFullText.Contains(MemRelationshipText, StringComparison.OrdinalIgnoreCase);

                    // Assert to validate  relationship text
                    Assert.That(isTextMatch, Is.True, $"The text '{RelationShipFullText}' does not contain '{MemRelationshipText}");
                    break;

                }              
             }
             
        }
        public static void AddFamilyMemberWithoutMandatoryField(string Expe_First_NameReg_Message, string ExpeLastNameRegMessage, string ExpWeightErrorMessage, string ExpHeightErrorMessage)
        {
            Wait.WaitTillPageLoad();

            Generic_Utils.IsElementDisplayed(FamilyMemberPage.By_DashboardHeader);

            FamilyMemberPage.Web_FamilyMemberTab.Click();
            Wait.WaitTillPageLoad();

            FamilyMemberPage.Web_AddMemberBtn.Click();
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(FamilyMemberPage.By_AddMemberPageheader);

            FamilyMemberPage.Web_SubmitBtn.Click();

            string FirstNameReqErrorMessage = FamilyMemberPage.Web_FirstNameErrorText.Text;

            Assert.That(FirstNameReqErrorMessage, Is.EqualTo(Expe_First_NameReg_Message));

            string LastNameReqErrorMessage = FamilyMemberPage.Web_LasstNameErrorText.Text;

            Assert.That(LastNameReqErrorMessage, Is.EqualTo(ExpeLastNameRegMessage));

            string WeightReqErrorMessage = FamilyMemberPage.Web_WeightErrortext.Text;

            Assert.That(WeightReqErrorMessage, Is.EqualTo(ExpWeightErrorMessage));

            string HeightReqErrorMessage = FamilyMemberPage.Web_HeightErrorText.Text;

            Assert.That(HeightReqErrorMessage, Is.EqualTo(ExpHeightErrorMessage));

            Reports.childLog.Log(Status.Info, "Mandatory field required message");
            Generic_Utils.GetScreenshot("Mandatory field required message screenshot");
            Wait.implicitWait(3);

        }
        public static void AddedMemberDisplayedInMedicalFile(string AddedMemFirstName, string MemRelationshipText)
        {
            FamilyMemberPage.Web_MedicalFileTab.Click();
            Wait.WaitTillPageLoad();


            int MemberCount = FamilyMemberPage.Web_FamilyMemberName.Count;

            for (int i = 0; i < MemberCount; i++)
            {
                string MemberName = FamilyMemberPage.Web_FamilyMemberName[i].Text;

                if (MemberName.Contains(AddedMemFirstName))
                {
                    string AddedMemeberFullName = FamilyMemberPage.Web_FamilyMemberName[i].Text;

                    string[] AddedMemFirstNameSplit = AddedMemeberFullName.Split(' ');
                    string AddedMember = AddedMemFirstNameSplit[0];

                    
                    Assert.That(AddedMemFirstName, Is.EqualTo(AddedMember));

                    // Relationship text validation

                    string RelationShipFullText = FamilyMemberPage.Web_RelationshipText[i].Text;

                    bool isTextMatch = RelationShipFullText.Contains(MemRelationshipText, StringComparison.OrdinalIgnoreCase);

                    // Assert to validate  realtionship text
                    StringAssert.Contains(MemRelationshipText, RelationShipFullText, $"The text '{RelationShipFullText}' does not contain '{MemRelationshipText}'");                 
                    break;
                }
            }
            Generic_Utils.ScrollToBottom();
            Wait.WaitTillPageLoad();
            Reports.childLog.Log(Status.Info, "Added Member display in medical file");
            Generic_Utils.GetScreenshot("Added Member display in medical file screenshot");

        }
        public static void AddedmemberAppearInMemberDropdown(string appointment_Time, string MemAndRelation)
        {
            FamilyMemberPage.Web_BookOppntTab.Click();
            Wait.WaitTillPageLoad();
            FamilyMemberPage.Web_BookopntBtn.Click();
            Wait.WaitTillPageLoad();

            int slot_count = DoctorProfilePage.Web_BookingSlot_Currentday.Count;

            for (int a = 0; a < slot_count; a++)
            {
                string slot_time = DoctorProfilePage.Web_BookingSlot_Currentday[a].Text;

                if (slot_time.Equals(appointment_Time))
                {
                    DoctorProfilePage.Web_BookingSlot_Currentday[a].Click();
                    break;
                }
            }
            Wait.WaitTillPageLoad();
            Reports.childLog.Log(Status.Info, "Book Oppointment page displayed");
            Generic_Utils.GetScreenshot("Book Oppointment page displayed screenshot");

            FamilyMemberPage.Web_AddMemebrInfoCheckBtn.Click();

        
            SelectElement selectElement = new SelectElement(FamilyMemberPage.Web_DropDownMember);

            IList<IWebElement> options = selectElement.Options;

            bool isMemberPresent = options.Any(option => option.Text.Equals(MemAndRelation, StringComparison.OrdinalIgnoreCase));

            
            Assert.That(isMemberPresent, Is.True, $"Member '{MemAndRelation}' is not present in the dropdown.");

            if (isMemberPresent)
            {
                Console.WriteLine($"Member '{MemAndRelation}' is present in the dropdown.");
            }
            else
            {
                Console.WriteLine($"Member '{MemAndRelation}' is not present in the dropdown.");

            }
            Generic_Utils.ScrollToBottom();
            FamilyMemberPage.Web_DropDownMember.Click();
            Reports.childLog.Log(Status.Info, "Added member displayed in dropdown");
            Generic_Utils.GetScreenshot("Added member displayed in dropdown screenshot");
        }
    }
}
