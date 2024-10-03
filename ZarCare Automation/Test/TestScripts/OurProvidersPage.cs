namespace TestScripts
{

    public class OurProvidersPage : Base
    
    {
       
        [Test]
        public void Search_Provider_On_OurProviders()
        {
    
            Reports.childLog = Reports.CreateNode("Step 1: Search Provider with Name, Category, and Location ");
            OurProviderWorkflow.Search_Provider_By_Name();
            OurProviderWorkflow.Search_Provider_By_Category();  
            OurProviderWorkflow.Search_Provider_By_Location();
            Reports.FlushNode(Reports.childLog);

        }

        [Test]
        public void Verify_Slot_Count()
        {
            Reports.childLog = Reports.CreateNode("Step 1:Verify Total Slot Count with Slots "); 
            OurProviderWorkflow.Validate_AppointmentSlot_With_TotalCount_On_OurProviderPage();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void Verify_RegisterPage_Through_OurProvider()
        {
            Reports.childLog = Reports.CreateNode("Step 1:Validate Register Page Through Book Appointment Button in Provider Page");
            OurProviderWorkflow.Validate_Register_Page_Through_BookAppointmentButton();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void Verify_RegisterPage_Through_Provider_Profile()
        {
            Reports.childLog = Reports.CreateNode("Step 1:Validate Register Page Through Doctor Profile Page");
            OurProviderWorkflow.Verify_Register_Page_Title_Through_Doctor_Profile();
            Reports.FlushNode(Reports.childLog);
        }



        [Test]
        public void Verify_Slot_After_Cancellation()
        {
            Reports.childLog = Reports.CreateNode("Step 1:Verify that Appt Slot Enables in OurProvider Page After Cancellation ");
            OurProviderWorkflow.Verify_Slot_Visible_On_OurProvider_Page_After_Cancellation();   
            Reports.FlushNode(Reports.childLog);
        }

    }
}
