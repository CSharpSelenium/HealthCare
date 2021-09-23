using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TY_Selenium_UnitTest.Commons
{
    public class Browser
    {
        public static IWebDriver driver { get; set; }
        public static ChromeOptions chromeOptions = new ChromeOptions();
        public static void BrowserOpen()
        {
            switch (Constants.Browser.ToLower())
            {
               
                case "chrome":
                   chromeOptions.AddArgument("start-maximized");
                   // driver.Manage().Window.Maximize();
                    driver = new ChromeDriver(chromeOptions);
                    driver.Url = Constants.Url;
                   // driver.Manage().Window.Maximize();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    driver.Url = Constants.Url;
                    driver.Manage().Window.Maximize();
                    break;
                case "ie":
                    driver = new InternetExplorerDriver();
                    driver.Url = Constants.Url;
                    driver.Manage().Window.Maximize();
                    break;
                default:
                    driver = new ChromeDriver();
                    driver.Url = Constants.Url;
                    driver.Manage().Window.Maximize();
                    break;
            }
        }

        public static void BrowserClose()
        {
            driver.Close();
        }
    }
}
