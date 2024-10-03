namespace ZarCare_Automation.Test.PageActions
{
    public class Find_Provider_Page:WebdriverSession
    {
        public static Find_Provider_Page_Locator FindProvider = new Find_Provider_Page_Locator();
    
        public static void Validate_Find_Provider_Page()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(FindProvider.By_Find_Provider_Page_Confirmation_Text);

            Reports.childLog.Log(Status.Info, "Find Provider page is displayed");
            Generic_Utils.GetScreenshot("Find Provider page screenshot");
        }

        public static void Search_Provider()
        {
            IWebElement Category_Dropdown =  FindProvider.Web_Category_Dropdown;
            Generic_Utils.Dropdown_Handle_With_Value(Category_Dropdown, "2");
            FindProvider.Web_Search_Button.Click();
            Wait.GenericWait(3000);
        }

        public static void Get_Provider_From_List(string providerName)
        {
            int provider_List = FindProvider.Web_Provider_List.Count;
            
            for (int i = 0; i < provider_List; i++)
            {
                string provider_Name = FindProvider.Web_Provider_Name.Text;

               if (provider_Name.Contains(providerName))
                {
                  FindProvider.Web_Book_Appointment_Button.Click(); 
                  break; 
                }
            }
        }

        public static void Click_On_Appointment_Date(string appointmentDate, string appointmentTime)
        {
            int get_Date_List = FindProvider.Web_Appointment_Date_Text.Count;
            IWebElement get_Today_Date = FindProvider.Web_Today_Date_Text;

            if (appointmentDate.Equals(get_Today_Date.Text))
            {
                get_Today_Date.Click();
                Click_On_Provider_Slot(appointmentTime);
            }
            
            else
            {
                for (int a = 0; a < get_Date_List; a++)
                {
                    string captureDateText = FindProvider.Web_Appointment_Date_Text[a].Text;

                    if (captureDateText.Equals(appointmentDate))
                    {
                        FindProvider.Web_Appointment_Date_Text[a].Click();
                        break;
                    }
                }
                Wait.GenericWait(2000);
                Click_On_Provider_Slot(appointmentTime);
            }
            
        }

        public static void Click_On_Provider_Slot(string appointmentTime)
        {

            IList<IWebElement> get_Slots = FindProvider.Web_Get_Provider_Slot_List;

            for (int a = 0; a < get_Slots.Count; a++)
            {
                string slotTime = FindProvider.Web_Get_Provider_Slot_List[a].Text;

                if (slotTime.Equals(appointmentTime))
                {
                    FindProvider.Web_Get_Provider_Slot_List[a].Click();
                    break;
                }
            }
        }
    }
}
