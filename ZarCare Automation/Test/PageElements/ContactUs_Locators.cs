using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageElements
{
    public class ContactUs_Locators : WebdriverSession
    {
        public By By_PageHeaderElement = By.CssSelector("div[class='page-title'] h1");
        public IWebElement Web_PageHeaderText => driver.FindElement(By_PageHeaderElement);

        public By By_Contact_Name = By.Id("txtName");
        public IWebElement Web_Contact_Name => driver.FindElement(By_Contact_Name);

        public By By_Contact_Email = By.Id("txtEmail");
        public IWebElement Web_Contact_email => driver.FindElement(By_Contact_Email);

        public By By_Contact_Enquiry = By.Id("txtEnquiry");
        public IWebElement Web_Contact_Enquiry => driver.FindElement(By_Contact_Enquiry);

        public By By_Submit_Button = By.Id("btnSubmit");
        public IWebElement Web_Button_Submit => driver.FindElement(By_Submit_Button);

        public By By_ThankYou_Page_Success_Message = By.CssSelector("div[class='page-title'] h1");
        public IWebElement Web_ThankYou_Page_Success_Message => driver.FindElement(By_ThankYou_Page_Success_Message);

        public By By_ContactUs_Name_Error = By.Id("NameError");
        public IWebElement Web_ContactUs_Name_Error => driver.FindElement(By_ContactUs_Name_Error);

        public By By_ContactUs_Email_Error = By.Id("EmailError");
        public IWebElement Web_ContactUs_Email_Error => driver.FindElement(By_ContactUs_Email_Error);

        public By By_ContactUs_Enquiry_Error = By.Id("EnquiryError");
        public IWebElement Web_ContactUs_Enquiry_Error => driver.FindElement(By_ContactUs_Enquiry_Error);


    }
}
