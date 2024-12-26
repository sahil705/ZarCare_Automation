namespace TestScripts
{
    public class FamilyMembers : Base
    {
        [Test]
        public void SubmitAndVerifyFamilyMemberProfileWithValidationMessage()
        {
            Reports.childLog = Reports.CreateNode("Submit the Family Memeber Profile Form ");
            FamilyMemberPageValidation.AddFamilyMemberwithValiddata();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]

        public void VerifyValidationMessageForMandatoryField()
        {
            Reports.childLog = Reports.CreateNode("Validation message for mandatory field");
            FamilyMemberPageValidation.ValidateMandatoryFielddForFamilyMember();
        }

        [Test]
       public void VerifyAddedMemberDisplayInMedilcal_file()
        {
            Reports.childLog = Reports.CreateNode("Validation added family member into Medical file");
            FamilyMemberPageValidation.AddedMemberDisplayInMedilcalfile();
        }

        [Test]

        public void VerifyAddedMemberApprearInDropDown()
        {
            Reports.childLog = Reports.CreateNode("Validation added family member Displayed into member's dropdown");
            FamilyMemberPageValidation.AddedMemberDisplayedInFamilyMemberDropDown();

        }

    }
}
