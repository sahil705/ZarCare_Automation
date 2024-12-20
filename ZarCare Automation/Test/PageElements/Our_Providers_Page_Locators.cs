namespace ZarCare_Automation.Test.PageElements
{
    public class Our_Providers_Page_Locators : WebdriverSession
    {
        public By By_SearchHeader = By.XPath("//div[@class='card-header open-search']/h4");
        public IWebElement Web_SearchHeader => driver.FindElement(By_SearchHeader);
        
        public By By_Doctor_SearchBox = By.Id("txtSearchString");
        public IWebElement Web_Doctor_SearchBox => driver.FindElement(By_Doctor_SearchBox);

        public By By_Doctor_SearchButton = By.XPath("//div[@class='btn-search']/button");
        public IWebElement Web_Doctor_SearchButton => driver.FindElement(By_Doctor_SearchButton);

        public By By_Doctor_List = By.XPath("//div[@class='card mb-4 history-list']/div");
        public IWebElement Web_Doctor_List => driver.FindElement(By_Doctor_List);


        public By By_Doctor_Name_List = By.XPath("//h4[@class='doc-name']/a");
        public IWebElement Web_Doctor_Name_List => driver.FindElement(By_Doctor_Name_List);

        public By By_DrJashanKumr= By.XPath("//a[contains(text(),'Jashan Kumar')]");
        public IWebElement Web_DrJashan_kumar_Ele=> driver.FindElement(By_DrJashanKumr);

        public By By_BookOppntbtn = By.XPath("//a[@class='apt-btn book-appointment']");
        public IWebElement Web_BookOptn_ele => driver.FindElement(By_BookOppntbtn);

        public IList<IWebElement> BookOtpbtnList = driver.FindElements(By.XPath("//div[@class='clinic-booking']//a[contains(@class, 'apt-btn book-appointment collapsed') or contains(@class, 'apt-btn book-appointment')]")); 
              
        public By By_Doctor_Specialty = By.XPath("//div[@class='doc-info-cont doc-info-count-new']/h5");
        public IWebElement Web_Doctor_Specialty => driver.FindElement(By_Doctor_Specialty);

        public By By_Doctor_Location = By.XPath("//p[@class='doc-location mb-0']");
        public IWebElement Web_Doctor_Location => driver.FindElement(By_Doctor_Location);

        public By By_Clear_Search_Icon = By.XPath("//button[@class='btn-search-clear']");
        public IWebElement Web_Clear_Search_Icon => driver.FindElement(By_Clear_Search_Icon);
        
        public By By_AllDoctors_CategoryList = By.XPath("//ul[@class='filter-list']/li");
        public IList<IWebElement> Web_AllDoctors_CategoryList => driver.FindElements(By_AllDoctors_CategoryList);

        public By By_Select_Specific_Category = By.XPath("//a[contains(text(),'Counsellor')]");
        public IWebElement Web_Select_Specific_Category => driver.FindElement(By_Select_Specific_Category);

        public By By_Category_Title = By.XPath("//h5[@class='doc-department']/i");
        public IWebElement Web_Category_Title => driver.FindElement(By_Category_Title);

        public By By_Category_Clear_Button = By.XPath("//h4[@class='position-relative']/button");
        public IWebElement Web_Category_Clear_Button => driver.FindElement(By_Category_Clear_Button);

        public By By_Doctor_Name = By.XPath("//div[@class='card mb-4 history-list']/div //h4[@class='doc-name']/a");
        public IList <IWebElement> Web_Doctor_Name => driver.FindElements(By_Doctor_Name);

        public By By_NextDateHeaderText = By.XPath("//div[@class='owl-item active']//h4[@class='heading']");
        public IWebElement Web_NextDateHeaderText => driver.FindElement(By_NextDateHeaderText);

        public By By_Total_Slot_Count_Current_Date = By.XPath("//div[@class='owl-item active current'] //p[@class='color-green sub-heading mb-1']");
        public IWebElement Web_Total_Slot_Count_Current_Date => driver.FindElement(By_Total_Slot_Count_Current_Date);

        public By By_Slot_Today = By.XPath("//div[@class='owl-item active current']/div/h4");
        public IWebElement Web_Slot_Today => driver.FindElement(By_Slot_Today);

        public By By_Slot_List = By.XPath("//div[@class='owl-item active'] //div[@class='c-day-session-slot-blue']");
        public IList<IWebElement> Web_Slot_List => driver.FindElements(By_Slot_List);

        public By By_Slot_Next_Days = By.XPath("//div[@class='owl-item active']/div/h4");
        public IList<IWebElement> Web_Slot_Next_Days => driver.FindElements(By_Slot_Next_Days);

        public By By_Slot_Tool_Tip = By.XPath("//div[@class='tooltip-inner']");
        public IWebElement Web_Slot_Tool_Tip => driver.FindElement(By_Slot_Tool_Tip);

        public By By_Provider_List = By.XPath("//div[@class='card mb-4 history-list']");
        public IList<IWebElement> Web_Provider_List => driver.FindElements(By_Provider_List);

        public By By_Book_Appointment_Button = By.XPath(".//div[@class='doc-info-right'] //div[@class='clinic-booking']");
        public IWebElement Web_Book_Appointment_Button => driver.FindElement(By_Book_Appointment_Button);

        public By By_Provider_Name = By.XPath("//div[@class='card mb-4 history-list']/div //h4[@class='doc-name']/a");
        public IWebElement Web_Provider_Name => driver.FindElement(By_Provider_Name);

    }

}


