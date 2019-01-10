using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace BDD.Common
{
    class Base
    {
        public static IWebDriver driver = null;

        public static void IntDriver()
        {
            
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxProfileManager pm = new FirefoxProfileManager();
            profile = pm.GetProfile("default");
            String browser = ConfigurationManager.AppSettings.Get("Browser");

            if (browser.Equals("chrome"))
            {

                driver = new ChromeDriver(chromeOptions());

            }
            else if (browser.Equals("firefox"))
            {
                FirefoxBinary binary = new FirefoxBinary(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe");
                driver = new FirefoxDriver(binary, profile);
            }
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("url"));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(Convert.ToInt32(ConfigurationManager.AppSettings.Get("wait"))));

        }

        private static ChromeOptions chromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return options;
        }

        public void isPageLoad()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            wait.Until(checkPageToLoad());
            Console.WriteLine("Waited for Page load ");

        }

        private Func<IWebDriver, bool> checkPageToLoad()
        {
            return ((x) =>
            {
                return ((IJavaScriptExecutor)x).ExecuteScript(
                       "return document.readyState").Equals("complete");
            });
        }

    }
}
