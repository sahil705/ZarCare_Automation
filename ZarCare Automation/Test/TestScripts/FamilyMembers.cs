namespace TestScripts
{
    public class FamilyMembers : Base
    {
        [Test]
        public void Submit_AndVerify_Family_MemberProfile_Display_In_MedicalFile_And_Member_DropDown()
        {
            Reports.childLog = Reports.CreateNode("Submit the Family Member Profile Form ");
            FamilyMemberPageValidation.SubmitFamilyMember();

            Reports.childLog = Reports.CreateNode("Validate added family member into Medical file");
            FamilyMemberPageValidation.AddedMemberDisplayInMedicalFile();

            Reports.childLog = Reports.CreateNode("Validate added family member Displayed into member's dropdown");
            FamilyMemberPageValidation.AddedMemberDisplayedInFamilyMemberDropDown();
            Reports.FlushNode(Reports.childLog);
            
        }

        [Test]

        public void VerifyValidationMessageForMandatoryField()
        {
            Reports.childLog = Reports.CreateNode("Validation message for mandatory field");
            FamilyMemberPageValidation.ValidateMandatoryFieldForFamilyMember();
            Reports.FlushNode(Reports.childLog);
        }

    }
}
