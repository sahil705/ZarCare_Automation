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

        public By By_My_Profile_Link = By.CssSelector("#liMyProfile");
        public IWebElement Web_My_Profile_Link => driver.FindElement(By_My_Profile_Link);

        // Dashboard element

        public By By_DashboardHeader = By.XPath("//h4[@class='card-title']");
        public IWebElement Web_DashboardHeader => driver.FindElement(By_DashboardHeader);

        public By By_FamilyMembertab = By.XPath("//a[@href='/Patient/FamilyMemberProfile']");
        public IWebElement Web_FamilyMemberTab => driver.FindElement(By_FamilyMembertab);

        public By By_AddMemberBtn = By.XPath("//a[@href='/Patient/FamilyMemberProfile/Add']");
        public IWebElement Web_AddMemberBtn => driver.FindElement(By_AddMemberBtn);


        public By By_MedicalFilesTab = By.XPath("//a[@href='/Patient/MedicalFile']");
        public IWebElement Web_MedicalFilesTab => driver.FindElement(By_MedicalFilesTab);


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

        public By By_RatingButton = By.XPath(".//a[starts-with(@id, 'btnRatethisDoctor')]");
        public IWebElement Web_RatingButton => driver.FindElement(By_RatingButton);

        public By By_RatingExistText = By.XPath("//span[@id='spnModalSuccessMessage']");
        public IWebElement Web_RatingExistText => driver.FindElement(By_RatingExistText);

        public By By_RatingPopup = By.XPath("(//h4[@id='myModalLabel'])[2]");
        public IWebElement Web_RatingPopup => driver.FindElement(By_RatingPopup);
        public By By_StarRatings(string starValue) => By.XPath($"//ul[@id='stars']/li[@class='star' and @data-value='{starValue}']");
        public IWebElement Web_StarRatings(string starValue) => driver.FindElement(By_StarRatings(starValue));

        public By By_RatingComment = By.Id("txtComment");
        public IWebElement Web_RatingComment => driver.FindElement(By_RatingComment);

        public By By_RatingSaveButton = By.Id("btnSaveRating");
        public IWebElement Web_RatingSaveButton => driver.FindElement(By_RatingSaveButton);

        public By By_Last3AppointmentSectionHeader = By.XPath("//h4[contains(text(), 'Last 3 Appointment')]/a[@class='viewall']");
        public IWebElement Web_Last3AppointmentSectionHeader =>driver.FindElement(By_Last3AppointmentSectionHeader);

        public By By_RepeatRequestButton = By.Id("btnRepeatScript");

        public By By_DoctorNotAvailableHeader = By.XPath("//div[@id='repeatPrescriptionSent']//h4[@id='subscribeStatusLabel']");

        public By By_DoctorNotAvailablePopupText = By.CssSelector("span[id='spnSentSuccess'] div");
        public IWebElement Web_DoctorNotAvailablePopupText => driver.FindElement(By_DoctorNotAvailablePopupText);

        public By By_PastThreeMonthAppointmentPopupText = By.XPath("//span[@id='spnSentSuccess']");
        public IWebElement Web_PastThreeMonthAppointmentPopupText => driver.FindElement(By_PastThreeMonthAppointmentPopupText);

        public By By_CheckOutPageElement = By.CssSelector("div[class='bg-white p-3 rounded-4 border-gray add_patient_info mt-0'] h4[class='title_heading m-0 border-bottom pb-2']");

        public By By_Repeat_Prescription_Submit_Button = By.Id("btnRepeatRequest");
        public IWebElement Web_Repeat_Prescription_Submit_Button => driver.FindElement(By_Repeat_Prescription_Submit_Button);



    }

}
