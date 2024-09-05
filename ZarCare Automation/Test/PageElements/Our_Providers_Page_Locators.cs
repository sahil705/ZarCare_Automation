﻿namespace ZarCare_Automation.Test.PageElements
{
    public class Our_Providers_Page_Locators : WebdriverSession
    {
        public By By_SearchHeader = By.Id("//div[@class='card-header open-search']/h4");
        public IWebElement Web_SearchHeader => driver.FindElement(By_SearchHeader);
        
        public By By_Doctor_SearchBox = By.Id("txtSearchString");
        public IWebElement Web_Doctor_SearchBox => driver.FindElement(By_Doctor_SearchBox);

        public By By_Doctor_SearchButton = By.XPath("//div[@class='btn-search']/button");
        public IWebElement Web_Doctor_SearchButton => driver.FindElement(By_Doctor_SearchButton);

        public By By_Doctor_List = By.XPath("//div[@class='card mb-4 history-list']/div");
        public IWebElement Web_Doctor_List => driver.FindElement(By_Doctor_List);

        public By By_Doctor_Name = By.XPath("//div[@class='card mb-4 history-list']/div //h4[@class='doc-name']/a");
        public IWebElement Web_Doctor_Name => driver.FindElement(By_Doctor_Name);

        public By By_Doctor_Specialty = By.XPath("//div[@class='doc-info-cont doc-info-count-new']/h5");
        public IWebElement Web_Doctor_Specialty => driver.FindElement(By_Doctor_Specialty);

        public By By_Doctor_Location = By.XPath("//div[@class='clinic-details mb-0']");
        public IWebElement Web_Doctor_Location => driver.FindElement(By_Doctor_Location);

        public By By_Clear_Search_Icon = By.XPath("//button[@class='btn-search-clear']");
        public IWebElement Web_Clear_Search_Icon => driver.FindElement(By_Clear_Search_Icon);
        
    }
}
