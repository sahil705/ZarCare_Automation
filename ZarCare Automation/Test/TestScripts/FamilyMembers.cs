namespace TestScripts
{
    public class FamilyMembers : Base
    {
        [Test]
        public void SubmitAndVerifyFamilyMemberProfile()
        {
            Reports.childLog = Reports.CreateNode("Submit the Family Member Profile Form ");
            FamilyMemberPageValidation.AddFamilyMemberwithValiddata();
            Reports.FlushNode(Reports.childLog);
        }


    }
}
