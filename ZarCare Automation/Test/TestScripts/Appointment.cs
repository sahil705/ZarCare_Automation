namespace TestScripts
{
    public class Appointment() : Base
    {
       
        [Test]
        public void Book_Appointment_Using_Login()
        {
            Reports.childLog = Reports.CreateNode(" Appointment Booking Journey Through Portal ");
            ActiveAppointmentValidation.Book_Appointment_Through_Portal();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void Book_Appointments_WithOut_Login()
        {
            Reports.childLog = Reports.CreateNode(" Appointment Booking Journey Through Public Website ");
            ActiveAppointmentValidation.Book_Appointment_Through_Public_Website();
            Reports.FlushNode(Reports.childLog);
        }

        [Test]
        public void CheckFileStatusAndNavigateToViewDetailPage()
        {
            Reports.childLog = Reports.CreateNode(" Navigation to View Detail Page After Checking the Medical File Status ");
            ActiveAppointmentValidation.HandleMedicalFileStatusAndRedirection();
            Reports.FlushNode(Reports.childLog);
        }
    }
}
