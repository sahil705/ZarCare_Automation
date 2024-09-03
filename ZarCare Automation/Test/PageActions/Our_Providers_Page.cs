using System.Collections;
using System.Runtime.CompilerServices;

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

        public static void Search_Doctor(string doctorName)
        {
            OurProvidersPage.Web_Doctor_SearchBox.SendKeys(doctorName);
            Wait.GenericWait(1000);
            OurProvidersPage.Web_Doctor_SearchButton.Click();
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

        //Doctors List By Specific Category

        public static void ValidateAllCategory_And_Click_Category(string doc_category )
        {
            IList<IWebElement> doctor_category = OurProvidersPage.Web_AllDoctors_CategoryList;
            foreach(IWebElement doctor in doctor_category)
            {
                string capture_category_text = doctor.Text;
                if (capture_category_text.Contains(doc_category))
                {
                    doctor.Click();
                    break;
                }
            }
        }

        //public static void ValidateSelectedCategory()
        //{
        //    bool SelectedCategoryVisible = OurProvidersPage.Web_Category_Title.Displayed;
        //    //Console.WriteLine(SelectedCategoryVisible);
        //    if (SelectedCategoryVisible == true)
        //    {
        //        Thread.Sleep(2000);
        //        Reports.childLog.Log(Status.Info, "Specific Category is selected");
        //        Generic_Utils.GetScreenshot("Category Screenshot");
        //        //OurProvidersPage.Web_Category_Clear_Button.Click();
        //        Thread.Sleep(1000);
        //    }
        //}

        public static void ValidateSelectedCategory(string OriginalCategoryTitle)
        {
            Assert.True(Generic_Utils.IsElementDisplayed(OurProvidersPage.By_Category_Title), OriginalCategoryTitle);
        }

    }
}
