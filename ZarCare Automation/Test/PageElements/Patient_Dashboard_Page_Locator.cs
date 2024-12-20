using static System.Collections.Specialized.BitVector32;

namespace ZarCare_Automation.Test.PageElements
{
    public class Patient_Dashboard_Page_Locator:WebdriverSession
    {
        public By By_Patient_Dashboard_Confirmation_Text = By.XPath("//span[@style='text-transform:capitalize;']");
        public IWebElement Web_Patient_Dashboard_Confirmation_Text => driver.FindElement(By_Patient_Dashboard_Confirmation_Text);

        public By By_Find_Provider_Link = By.CssSelector("#liFindDoctor");
        public IWebElement Web_Find_Provider_Link => driver.FindElement(By_Find_Provider_Link);

        public By By_Active_Appointment_View_All_Link = By.XPath("(//div[@class = 'card mb-4']//h4[@class='card-title']/a)[2]");
        public IWebElement Web_Active_Appointment_View_All_Link => driver.FindElement(By_Active_Appointment_View_All_Link);

        public By By_Profile_Name_Heading = By.XPath("//div[@class='profile-det-info']/h3");
        public IWebElement Web_Profile_Name_Heading => driver.FindElement(By_Profile_Name_Heading);

        public By By_Update_Icon = By.XPath("//h4[@class='card-title']/a[@id='Update']");
        public IWebElement Web_Update_Icon => driver.FindElement(By_Update_Icon);

        public By By_ProfilePic_Icon = By.XPath("//div[@class='widget-profile']/div[@class='profile-info-widget']/a");
        public IWebElement Web_ProfilePic_Icon => driver.FindElement(By_ProfilePic_Icon);

        public By By_Patient_Name = By.XPath("(//div[@class='form-group']/h5)[1]");
        public IWebElement Web_PatientName => driver.FindElement(By_Patient_Name);

        public By By_Patient_Gender = By.XPath("(//div[@class='form-group']/h5)[2]");
        public IWebElement Web_Patient_Gender => driver.FindElement(By_Patient_Gender);

        public By By_Patient_Weight = By.XPath("(//div[@class='form-group']/h5)[5]");
        public IWebElement Web_Patient_Weight => driver.FindElement(By_Patient_Weight);

        public By By_Patient_Height = By.XPath("(//div[@class='form-group']/h5)[6]");
        public IWebElement Web_Patient_Height => driver.FindElement(By_Patient_Height);

        public By By_Patient_Address = By.XPath("(//div[@class='form-group']/h5)[9]");
        public IWebElement Web_Patient_Address => driver.FindElement(By_Patient_Address);

        public By By_Notification_Popup = By.XPath("//div[@id='dashboard-notifications']//div[@class='modal-content']");
        public IWebElement Web_Notification_Popup => driver.FindElement(By_Notification_Popup);

        public By By_Later_Button = By.Id("btnLater");
        public IWebElement Web_Later_Button => driver.FindElement(By_Later_Button);

        public By By_Subscribe_Button = By.Id("btnSubscribe");
        public IWebElement Web_Subscribe_Button => driver.FindElement(By_Subscribe_Button);

        // Dashboard element

        public By By_DashboardHeader = By.XPath("//h4[@class='card-title']");
        public IWebElement Web_DashboardHeader => driver.FindElement(By_DashboardHeader);

        public By By_FamilyMembertab = By.XPath("//a[@href='/Patient/FamilyMemberProfile']");
        public IWebElement Web_FamilyMemberTab => driver.FindElement(By_FamilyMembertab);

        public By By_AddMemberBtn = By.XPath("//a[@href='/Patient/FamilyMemberProfile/Add']");
        public IWebElement Web_AddMemberBtn => driver.FindElement(By_AddMemberBtn);

        public By By_UpcomingAppointmentHeader = By.XPath("//div[@class='card mb-4']//div[@class='card-body']//h4[@class='card-title']");
        public IWebElement Web_UpcomingAppointmentHeader => driver.FindElement(By_UpcomingAppointmentHeader);

        public By By_DashboardAppointmentList = By.CssSelector("table tr td:nth-child(1)");
        public IList <IWebElement> Web_DashboardAppointmentList =>driver.FindElements(By_DashboardAppointmentList);

        public By By_AppointmentRecords = By.CssSelector(".patient-widget.mb-4.position-relative");
        public IList<IWebElement> Web_AppointmentRecords => driver.FindElements(By_AppointmentRecords);

        public By By_ReferenceNumber = By.XPath(".//div[@class='history-info']/span[last()]");
       
        public By By_ViewInvoiceButton = By.XPath(".//a[text()='View Invoice']");
       
        public By By_InvoiceHeaderText = By.CssSelector("section.container h3");
        public IWebElement Web_InvoiceHeaderText => driver.FindElement(By_InvoiceHeaderText);

        public By By_InvoiceNumber = By.XPath("//div/p[contains(text(), 'Invoice Number')]");
        public IWebElement Web_InvoiceNumber => driver.FindElement(By_InvoiceNumber);

        





    }

}
