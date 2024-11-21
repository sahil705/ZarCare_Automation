using AngleSharp.Dom;
using OpenQA.Selenium.Interactions;

namespace ZarCare_Automation.Utilities
{
    public class Generic_Utils : WebdriverSession
    {
        public static void Initilize_Browser(string browser)
        {
            switch (browser)
            {
                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddUserProfilePreference("profile.default_content_setting_values.media_stream_mic", 1); 
                    options.AddUserProfilePreference("profile.default_content_setting_values.media_stream_camera", 1);
                    driver = new ChromeDriver(options);
                    break;

                case "firefox":

                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "edge":

                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }
        }

        public static void Initilize_URL(string environment, string urlType)
        {
            string url = Json_Reader.ReadJsonText(Generic_Utils.getDataPath("TestResources") + "\\URL.json")[environment][urlType].ToString();
            Generic_Utils.NavigateToURL(url);
            Wait.implicitWait(3);

        }

        public static string getDataPath(string foldername)
        {
            // Get the path of the current executing assembly
            string assemblyPath = Assembly.GetExecutingAssembly().Location;

            // Get the directory of the assembly
            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);

            // Get the parent directory of the assembly directory (i.e. the project folder)
            string projectDirectory = Directory.GetParent(assemblyDirectory).Parent.Parent.FullName;

            // Combine the project directory path with the "data" folder name to get the "data" folder path
            string dataFolderPath = Path.Combine(projectDirectory, foldername);

            return dataFolderPath;
        }

        public static string GetScreenshot(string message)
        {
            // Take a screenshot
            Screenshot sc = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshot = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;

            // Save the screenshot to a local file
            string screenshotPath = Path.Combine(Reports.screenshotFolderName, $"{DateTime.Now:HH-mm-ss}_screenshot.png");
            sc.SaveAsFile(screenshotPath);

            // Attach the screenshot to the Extent Report
            Reports.childLog.AddScreenCaptureFromPath(screenshotPath);

            Reports.childLog.Log(Status.Info, message, MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot).Build());

            return screenshotPath;
        }

        public static string CaptureFailScreenshot()
        {
            // Take a screenshot
            Screenshot sc = ((ITakesScreenshot)driver).GetScreenshot();

            // Save the screenshot to a local file
            string screenshotPath = Path.Combine(Reports.screenshotFolderName, $"{DateTime.Now:HH-mm-ss}_Test fail screenshot.png");
            sc.SaveAsFile(screenshotPath);

            return screenshotPath;
        }

        public static string CapturePassScreenshot()
        {
            // Take a screenshot
            Screenshot sc = ((ITakesScreenshot)driver).GetScreenshot();

            // Save the screenshot to a local file
            string screenshotPath = Path.Combine(Reports.screenshotFolderName, $"{DateTime.Now:HH-mm-ss}_Test pass screenshot.png");
            sc.SaveAsFile(screenshotPath);

            return screenshotPath;
        }

        public static void NavigateToURL(string url)
        {
            driver.Url = url;
        }

        public static void BrowserMaximize()
        {
            driver.Manage().Window.Maximize();
        }

        public static void BrowserMinimize()
        {
            driver.Manage().Window.Minimize();
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }

        public static void CloseDriver()
        {
            driver.Close();
        }

        public static string getTitle()
        {
            return driver.Title;
        }

        public static String waitForTitleContains(String titleFraction, int timeOut)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));

            try
            {
                if (wait.Until(ExpectedConditions.TitleContains(titleFraction)))
                {
                    return driver.Title;
                }
            }
            catch (TimeoutException e)
            {
                Console.WriteLine("title not found");
            }
            return driver.Title;
        }

        public static void RefreshPage(string url)
        {
            driver.Navigate().Refresh();
        }

        public static bool IsElementDisplayed(By locator)
        {
            try
            {
                return driver.FindElement(locator).Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string getText(IWebElement element)
        {
            return element.Text;
        }

        public static void ScrollPageDown(String height)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, '" + height + "');");
        }

        public static void ScrollToMiddle()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight/2);");
        }
        public static void ScrollToBottom()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        public static void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView()", element);
        }
        public static void ScrollToMidOfPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight / 2);");
        }

        public static void JavaScriptElementClick(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", element);
        }

        public static void GetCurrentDate()
        {
            DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss").Trim();
        }


        public static void WindowHandle()
        {
            var current_window = driver.CurrentWindowHandle;
            var all_windows = driver.WindowHandles;
            foreach (string window in all_windows)
            {
                if (window != current_window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
        }

        public static void getUrl()
        {
            string url = driver.Url;
        }

        public static void ClearTextBox(IWebElement element)
        {
            
            element.Clear();

        }

        public static void Dropdown_Handle_With_Value(IWebElement element, string value)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }

        public static void Dropdown_Handle_With_Index(IWebElement element, string index)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(index);
        }

        public static void Dropdown_Handle_With_Text(IWebElement element, string text)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(text);
        }

        public static void Action_For_Double_Click(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.DoubleClick(element).Build().Perform();
           
        }
        public static void Action_For_Click(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Build().Perform();

        }

        public static void HoverElement(IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Perform();
        }

        public static int ParseSlotCount(string slotCountText)
        {
            string[] splittedText = slotCountText.Split(" ");
            return int.Parse(splittedText[0].Trim());
        }

        public static void NavigateBack()
        {
            driver.Navigate().Back();
            Wait.GenericWait(2000);
        }


        public class Wait : WebdriverSession
        {
            public static void GenericWait(int milliseconds)
            {
                Thread.Sleep(milliseconds);
            }

            public static void implicitWait(int seconds)
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
            }

            public static void WaitTillPageLoad()
            {
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

                try
                {
                    webDriverWait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            public static void WaitForURLMatching(string url)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.UrlMatches(url));
            }

            public static void InvisibilityOfElementLocated(By locator, int second)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
            }

            public static IWebElement ElementIsVisible(By locator, int second)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
                return wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            public static IWebElement ElementIsClickable(IWebElement element, int second)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
                return wait.Until(ExpectedConditions.ElementToBeClickable(element));
            }

            public static void ElementsAreClickable(IList<IWebElement> elements, int timeoutInSeconds)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

                foreach (IWebElement element in elements)
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(element));
                }
            }

            public static IWebElement InvisibleOfElement(By locator, int second)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
                return wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
        }
    }
}