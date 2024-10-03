using System.Collections;
using System.Runtime.CompilerServices;

namespace ZarCare_Automation.Test.PageActions
{
    public class Our_Providers_Page : WebdriverSession
    {
        public static Our_Providers_Page_Locators OurProvidersPage = new Our_Providers_Page_Locators();
        public static Doctor_Profile_Page_Locators DoctorProfilePage = new Doctor_Profile_Page_Locators();
        public static Register_Page_Locator RegisterPage = new Register_Page_Locator();

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
        public static void ClickOnBookAppointmentButton(string Doctorsname)
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(OurProvidersPage.By_SearchHeader);
             
        
            int DrList = driver.FindElements(OurProvidersPage.By_Doctor_List).Count;

            for (int i = 0; i < DrList; i++)
            {
                string dr_name = (OurProvidersPage.Web_Doctor_Name)[i].Text;
                
                if (dr_name.Contains(Doctorsname))
                {
                   
                    IWebElement BookOptbtnfnl = (OurProvidersPage.BookOtpbtnList)[i];
                    IWebElement BookOptScroll = (OurProvidersPage.BookOtpbtnList)[i - 1];
                    Generic_Utils.ScrollToElement(BookOptScroll);
                    BookOptbtnfnl.Click();
                    break;
                }
            }

            Reports.childLog.Log(Status.Info, "doctor Detail Page displayed");
            Generic_Utils.GetScreenshot("doctor Detail Page screenshot");
   
        }
      

        // Main method to validate slots based on the appointment date
        public static void GetSlotCountAndValidateWithTotalCount(string appointmentDate)
        {
            string currentDisplayedDate = DoctorProfilePage.Web_BookingDateHeader_CurrentDate.Text;

            if (!currentDisplayedDate.Equals(appointmentDate))
            {
                ClickOnFutureDateSlot(appointmentDate);
            }

            ValidateSlotCount();

            Reports.childLog.Log(Status.Info, "Validate Slot Count with Total Slot");
            Generic_Utils.GetScreenshot("Provider Slot Div Screenshot");

        }

        // Method to click on the future date slot if it does not match the current date
        private static void ClickOnFutureDateSlot(string appointmentDate)
        {
            IList<IWebElement> nextDateSlots = driver.FindElements(OurProvidersPage.By_NextDateHeaderText);

            foreach (var dateSlot in nextDateSlots)
            {
                if (dateSlot.Text.Contains(appointmentDate))
                {
                    dateSlot.Click();
                    break;
                }
            }
        }

        // Method to validate the slot count (both today and future dates)
        private static void ValidateSlotCount()
        {
            string availableSlotText = Generic_Utils.getText(OurProvidersPage.Web_Total_Slot_Count_Current_Date);
            int displayedSlotCount = Generic_Utils.ParseSlotCount(availableSlotText);

            int actualSlotCount = DoctorProfilePage.Web_BookingSlot_Currentday.Count;

            Assert.That(displayedSlotCount, Is.EqualTo(actualSlotCount), $"Expected {displayedSlotCount}, but found {actualSlotCount} slots.");
        }


        public static void ClickOnProviderSlotAndNavigateToRegisterPage(string Appoint_Date, string appointment_Time)
        {
            string TodaysDate = DoctorProfilePage.Web_BookingDateHeader_CurrentDate.Text;
           

            if (TodaysDate.Equals(Appoint_Date))  //"Today condition"
            {
                int slot_count = DoctorProfilePage.Web_BookingSlot_Currentday.Count;

                for (int a = 0; a < slot_count; a++)
                {
                    string slot_time = DoctorProfilePage.Web_BookingSlot_Currentday[a].Text;


                    if (slot_time.Equals(appointment_Time))
                    {
                        DoctorProfilePage.Web_BookingSlot_Currentday[a].Click();
                        break;
                    }
                }
            }
            else
            {
                // next date
                int NextDateSlot = driver.FindElements(OurProvidersPage.By_NextDateHeaderText).Count;


                for (int b = 0; b < NextDateSlot; b++)
                {
                    string NextDateSlotText = driver.FindElements(OurProvidersPage.By_NextDateHeaderText)[b].Text;

                    if (NextDateSlotText.Contains(Appoint_Date))
                    {
                        IWebElement NextDateSlotEle = driver.FindElements(OurProvidersPage.By_NextDateHeaderText)[b];
                        NextDateSlotEle.Click();
                        int slot_count = DoctorProfilePage.Web_BookingSlot_Currentday.Count;

                        for (int a = 0; a < slot_count; a++)
                        {
                            string slot_time = DoctorProfilePage.Web_BookingSlot_Currentday[a].Text;


                            if (slot_time.Equals(appointment_Time))
                            {
                                DoctorProfilePage.Web_BookingSlot_Currentday[a].Click();
                                break;
                            }
                        }
                        break;
                    }
                   

                }
            }

        }
        public static void Get_and_Validate_OurProvider_Title(string Original_Title)
        {
            string Capture_Title = Generic_Utils.getTitle();
            Assert.That(Original_Title, Is.EqualTo(Capture_Title));
        }
        public static void Get_and_Validate_Doctor_Name(string Original_Text)
        {
            string DoctorName = Generic_Utils.getText(OurProvidersPage.Web_Doctor_Name_List);
            Assert.That(Original_Text, Is.EqualTo(DoctorName));

            Reports.childLog.Log(Status.Info, "Searched Provider List is displayed");
            Generic_Utils.GetScreenshot("Provider Name Screenshot");


        }

        public static void Get_and_Validate_Doctor_Specialty(string Original_Text)
        {
            string DoctorSpecialty = Generic_Utils.getText(OurProvidersPage.Web_Doctor_Specialty);
            Assert.That(Original_Text, Is.EqualTo(DoctorSpecialty));
            
            Reports.childLog.Log(Status.Info, "Searched Provider Speciality List is displayed");
            Generic_Utils.GetScreenshot("Provider Speciality Screenshot");
        }

      
        public static void Get_and_Validate_Doctor_Location(string Original_Text)
        {
            string DoctorLocation = Generic_Utils.getText(OurProvidersPage.Web_Doctor_Location);
            string[] splitText = DoctorLocation.Split(',');
            string getLocation = splitText[1].Trim();
            Assert.That(Original_Text.Contains(getLocation));

            Reports.childLog.Log(Status.Info, "Searched Provider Location List is displayed");
            Generic_Utils.GetScreenshot("Provider Location Screenshot");
        }

        public static void Get_and_Validate_ConnectNow_Popup(string Original_Text)
        {
            string ConnectNowPopup = Generic_Utils.getText(OurProvidersPage.Web_Doctor_List);
            Assert.That(Original_Text.Equals(ConnectNowPopup)); 
        }
       

        public static void ValidateAllCategory_And_Click_Category(string doc_category )
        {
           // Wait.ElementsAreClickable(OurProvidersPage.Web_AllDoctors_CategoryList, 10);
            IList <IWebElement> doctor_category = OurProvidersPage.Web_AllDoctors_CategoryList;
            foreach(IWebElement doctor in doctor_category)
            {
                string capture_category_text = doctor.Text.Trim();
                if (capture_category_text.Contains(doc_category))
                {
                    doctor.Click(); 
                    break;
                }
            }
        }

       
        public static void ValidateSelectedCategory(string OriginalCategoryTitle)
        {
            Assert.True(Generic_Utils.IsElementDisplayed(OurProvidersPage.By_Doctor_Specialty), OriginalCategoryTitle);
        }

        public static void RemoveCategory()
        {
            OurProvidersPage.Web_Category_Clear_Button.Click();
            Wait.GenericWait(3000);
            Reports.childLog.Log(Status.Info, "Selected Category is Disable");
            Generic_Utils.GetScreenshot("Doctors Category Removed");
        }

        public static void Validate_Top_Category(string OriginalCategoryTitle)
        {
            Assert.True(Generic_Utils.IsElementDisplayed(OurProvidersPage.By_Doctor_Specialty), OriginalCategoryTitle);
        }

    }
}

        