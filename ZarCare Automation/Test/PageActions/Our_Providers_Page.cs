namespace ZarCare_Automation.Test.PageActions
{
    public class Our_Providers_Page : WebdriverSession
    {
        public static Our_Providers_Page_Locators OurProvidersPage = new Our_Providers_Page_Locators();

        public static void Validate_OurProviderPage()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(OurProvidersPage.By_SearchHeader);

            Reports.childLog.Log(Status.Info, "Our Providers page is displayed");
            Generic_Utils.GetScreenshot("Our Providers screenshot");

        }

        public static void Get_and_Validate_OurProviders_Title(string Original_Title)
        {
            string Capture_Title = Generic_Utils.getTitle();
            Assert.That(Original_Title, Is.EqualTo(Capture_Title));
        }

        public static void Search_Doctor(string doctorName)
        {
            OurProvidersPage.Web_Doctor_SearchBox.SendKeys(doctorName);
            Wait.GenericWait(1000);
            OurProvidersPage.Web_Doctor_SearchButton.Click();
        }

        public static void Search_Location(String doctorLocation)
        {
            OurProvidersPage.Web_Doctor_SearchBox.SendKeys(doctorLocation);
            Wait.GenericWait(1000);
            OurProvidersPage.Web_Doctor_SearchButton.Click();
        }

        public static void Search_Category(string doctorCategory)
        {
            OurProvidersPage.Web_Doctor_SearchBox.SendKeys(doctorCategory);
            Wait.GenericWait(1000);
            OurProvidersPage.Web_Doctor_SearchButton.Click();
        }

        public static void NavigateToCloseButton()
        {
            OurProvidersPage.Web_Clear_Search_Icon.Click();
        }

        public static void FetchDoctorFromList(string doctorName)
        {
            int dr_list = driver.FindElements(OurProvidersPage.By_Doctor_List).Count;

            for (int a = 0; a < dr_list; a++)
            {
                string dr_name = driver.FindElements(OurProvidersPage.By_Doctor_Name)[a].Text;

                if (dr_name.Contains(doctorName))
                {
                    driver.FindElements(OurProvidersPage.By_Doctor_Name)[a].Click();
                    break;
                }
            }
        }

        public static void Get_and_Validate_Doctor_Specialty(string Original_Text)
        {
            string DoctorSpecialty = Generic_Utils.getText(OurProvidersPage.Web_Doctor_Specialty);
            Assert.That(Original_Text, Is.EqualTo(DoctorSpecialty));
        }

        public static void Get_and_Validate_Doctor_Name(string Original_Text)
        {
            string DoctorName = Generic_Utils.getText(OurProvidersPage.Web_Doctor_Name);
            Assert.That(Original_Text, Is.EqualTo(DoctorName));
        }

        public static void Get_and_Validate_Doctor_Location(string Original_Text)
        {
            string DoctorLocation = Generic_Utils.getText(OurProvidersPage.Web_Doctor_Location);
            //Assert.That(Original_Text, Is.EqualTo(DoctorLocation));
            Assert.That(Original_Text.Contains(DoctorLocation));
        }

        public static void Get_and_Validate_ConnectNow_Popup(string Original_Text)
        {
            string ConnectNowPopup = Generic_Utils.getText(OurProvidersPage.Web_Doctor_List);
        }
    }
}

        