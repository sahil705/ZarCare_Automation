namespace ZarCare_Automation.Test.PageElements
{
    public class Family_Member_page_Locator:WebdriverSession
    {
        // Dashboard element

        public By By_DashboardHeader = By.XPath("//h4[@class='card-title']");

        public IWebElement Web_DashboardHeader => driver.FindElement(By_DashboardHeader);

        public By By_FamilyMembertab = By.XPath("//a[@href='/Patient/FamilyMemberProfile']");

        public IWebElement Web_FamilyMemberTab => driver.FindElement(By_FamilyMembertab);

        public By By_AddMemberBtn = By.XPath("//a[@href='/Patient/FamilyMemberProfile/Add']");

        public IWebElement Web_AddMemberBtn => driver.FindElement(By_AddMemberBtn);

        // Member page element

        public By By_AddMemberPageheader = By.XPath("//div[@class='item-title item-label']");

        public IWebElement Web_AddMemberPageheader => driver.FindElement(By_AddMemberPageheader);

        public By By_MemberFirstName = By.XPath("//input[@id='txtFirstName']");

        public IWebElement Web_MemberFirstName => driver.FindElement(By_MemberFirstName);

        public By By_MemberlastName = By.XPath("//input[@id='txtLastName']");

        public IWebElement Web_MemberLastName => driver.FindElement(By_MemberlastName);

        public By By_MemberWeight = By.XPath("//input[@id='txtWeight']");

        public IWebElement Web_MemberWeight => driver.FindElement(By_MemberWeight);

        public By By_MemberHeight = By.XPath("//input[@id='txtHeight']");

        public IWebElement Web_MemberHeight => driver.FindElement(By_MemberHeight);

        public By By_GenderList = By.XPath("//select[@class='form-control select reqField select2-hidden-accessible']");

        public IWebElement Web_GenderList => driver.FindElement(By_GenderList);

        public By By_RelationList = By.XPath("//select[@id='RelationId']");

        public IWebElement Web_RelationList => driver.FindElement(By_RelationList);

        public By By_MemCountry = By.XPath("//input[@id='txtCountry']");

        public IWebElement Web_MemCountry => driver.FindElement(By_MemCountry);

        public By By_MemProvince = By.XPath("//input[@id='txtState']");

        public IWebElement Web_MemProvince => driver.FindElement(By_MemProvince);

        public By By_MemCity = By.XPath("//input[@id='txtCity']");

        public IWebElement Web_MemCity => driver.FindElement(By_MemCity);

        public By By_MemPinCode = By.XPath("//input[@id='txtPincode']");

        public IWebElement Web_MemPinCode => driver.FindElement(By_MemPinCode);

        public By By_MemAddress = By.XPath("//input[@id='txtAddress']");

        public IWebElement Web_MemAddress => driver.FindElement(By_MemAddress);

        public By By_UploadPhoto = By.XPath("//input[@id='file']");

        public IWebElement Web_UploadPhoto => driver.FindElement(By_UploadPhoto);

        public By By_SubmitBtn = By.XPath("//button[@id='btnSubmit']");

        public IWebElement Web_SubmitBtn => driver.FindElement(By_SubmitBtn);

        public By By_ActualSuccessMessage = By.XPath("//div[@id='message']");

        public IWebElement Web_ActualSuccessMessage => driver.FindElement(By_ActualSuccessMessage);

        //Error message locaters

        public By By_FirsNameErrorText = By.XPath("//span[@id='spnFirstName']");

        public IWebElement Web_FirstNameErrorText => driver.FindElement(By_FirsNameErrorText);

        public By By_lastNameErrorText = By.XPath("//span[@id='spnLastName']");

        public IWebElement Web_LasstNameErrorText => driver.FindElement(By_lastNameErrorText);

        public By By_WeightErrortext = By.XPath("//span[@id='spnErrorWeight']");

        public IWebElement Web_WeightErrortext => driver.FindElement(By_WeightErrortext);

        public By By_HeightErrortext = By.XPath("//span[@id='spnErrorHeight']");

        public IWebElement Web_HeightErrorText => driver.FindElement(By_HeightErrortext);


        //Medical File page locatores

        public By By_MedicalFileTab = By.XPath("//li[@id='liMedicalFiles']");

        public IWebElement Web_MedicalFileTab => driver.FindElement(By_MedicalFileTab);

        public By By_FamilyMemName = By.XPath("//div[@id='dvMedicalFileList']//h3//a");

        public IList<IWebElement> Web_FamilyMemberName => driver.FindElements(By_FamilyMemName);

        public By By_Relationshiptext = By.XPath("//*[contains(text(), 'Relationship')]");

        public IList<IWebElement> Web_RelationshipText => driver.FindElements(By_Relationshiptext);

        // Family member tab locators

        public By By_MemFullName = By.XPath("//div[@class='profile-det-info']/h3");

        public IList<IWebElement> Web_MemFullName => driver.FindElements(By_MemFullName);

        //Book Appointment lab locatores

        public By By_BookOppntTab = By.XPath("//ul//li[@id='liFindDoctor']");

        public IWebElement Web_BookOppntTab => driver.FindElement(By_BookOppntTab);

        public By By_BooKopntBtn = By.XPath("(//div[@class='clinic-booking-new'])[1]");

        public IWebElement Web_BookopntBtn => driver.FindElement(By_BooKopntBtn);

        public By By_AddmemberInfoCheckBtn = By.XPath("//input[@id='chkYes']");

        public IWebElement Web_AddMemebrInfoCheckBtn => driver.FindElement(By_AddmemberInfoCheckBtn);

        public By By_dropDownMemeber = By.XPath("//select[@id='PatientFamilyMemberId']");

        public IWebElement Web_DropDownMember => driver.FindElement(By_dropDownMemeber);

        

    }
}
