namespace TestScripts
{
    public class FamilyMembers : Base
    {
        [Test]
        public void Submit_AndVerify_Family_MemberProfile_Display_In_MedicalFileAnd_Memmber_DropDown()
        {
            Reports.childLog = Reports.CreateNode("Submit the Family Member Profile Form ");
            FamilyMemberPageValidation.AddFamilyMemberwithValiddata();

            Reports.childLog = Reports.CreateNode("Validate added family member into Medical file");
            FamilyMemberPageValidation.AddedMemberDisplayInMedilcalfile();

            Reports.childLog = Reports.CreateNode("Validate added family member Displayed into member's dropdown");
            FamilyMemberPageValidation.AddedMemberDisplayedInFamilyMemberDropDown();
            Reports.FlushNode(Reports.childLog);
            
        }

        [Test]

        public void VerifyValidationMessageForMandatoryField()
        {
            Reports.childLog = Reports.CreateNode("Validation message for mandatory field");
            FamilyMemberPageValidation.ValidateMandatoryFielddForFamilyMember();
        }

    }
}
