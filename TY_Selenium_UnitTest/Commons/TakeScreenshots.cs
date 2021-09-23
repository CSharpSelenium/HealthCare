using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TY_Selenium_UnitTest.Commons
{
   public class TakeScreenshots
    {
        public static void GetFailedScreenshots()
        {
            ITakesScreenshot takesScreenshot =(ITakesScreenshot) Browser.driver;
            takesScreenshot.GetScreenshot().SaveAsFile(@"C:\Users\Dwarkesh\source\repos\TY_Selenium_UnitTest\TY_Selenium_UnitTest\Screenshots\FailedScreenshots\"+TestContext.CurrentContext.Test.MethodName+".png");
            string img = GenerateReports.test.AddScreenCapture(@"C:\Users\Dwarkesh\source\repos\TY_Selenium_UnitTest\TY_Selenium_UnitTest\Screenshots\FailedScreenshots\" + TestContext.CurrentContext.Test.MethodName + ".png");
            GenerateReports.test.Log(LogStatus.Info, "Failed image status" + img);
           
        }
        public static void GetSkippedScreenshots()
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)Browser.driver;
            takesScreenshot.GetScreenshot().SaveAsFile(@"C:\Users\Dwarkesh\source\repos\TY_Selenium_UnitTest\TY_Selenium_UnitTest\Screenshots\SkippedScreenshots\" + TestContext.CurrentContext.Test.MethodName + ".png");

        }
    }
}
