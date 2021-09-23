using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TY_Selenium_UnitTest.Commons
{
    [TestFixture]
   //[Parallelizable(ParallelScope.All)]
    public class BaseTest:GenerateReports
    {
        
        [SetUp]
        public void BeforeTest()
        {
           // string s = "India is my country";
           //bool res=  s.Contains("our");
            GenerateReports.test = GenerateReports.report.StartTest(TestContext.CurrentContext.Test.MethodName+"!!! Started !!!");
            Browser.BrowserOpen();
            test.Log(LogStatus.Info, "Browser Launched");
            test.Log(LogStatus.Info, "Url Passed");
            if(TestContext.CurrentContext.Test.ClassName.Contains("Admin"))
            {
                Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Browser.driver.FindElement(By.XPath("//button[contains(text(),'Admin')]")).Click();

            }
            else if (TestContext.CurrentContext.Test.ClassName.Contains("Doctor"))
            {
                Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Browser.driver.FindElement(By.XPath("//button[contains(text(),'Doctor')]")).Click();
            }
            else if (TestContext.CurrentContext.Test.ClassName.Contains("Patient"))
            {
                Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Browser.driver.FindElement(By.XPath("//button[contains(text(),'Patient')]")).Click();
            }
            else if (TestContext.CurrentContext.Test.ClassName.Contains("Accountant"))
            {
                Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Browser.driver.FindElement(By.XPath("//button[contains(.,'Accountant')]")).Click();
                
            }
            else if (TestContext.CurrentContext.Test.ClassName.Contains("Doctor"))
            {

            }
            Console.Out.WriteLine("BeforeTest Started");

            Browser.driver.FindElement(By.XPath("//button[text()='Login']")).Click();


        }
        [TearDown]
        public void AfterTest()
        {
          var status=  TestContext.CurrentContext.Result.Outcome.Status;
            if(status==TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, TestContext.CurrentContext.Test.MethodName + "Failed");
                TakeScreenshots.GetFailedScreenshots();
             
            }
            else if (status==TestStatus.Skipped)
            {
                test.Log(LogStatus.Skip, TestContext.CurrentContext.Test.MethodName + "Skipped");

                TakeScreenshots.GetSkippedScreenshots();
            }
            else 
            {
                test.Log(LogStatus.Pass , TestContext.CurrentContext.Test.MethodName + "Passed");
            }
            Browser.driver.FindElement(By.XPath("//a[contains(text(),'Logout')]")).Click();
            Browser.BrowserClose();
            test.Log(LogStatus.Info, "Browser closed");
            report.EndTest(test);
            Console.Out.WriteLine("BeforeTest Ended");
        }
        //public void Login()
        //{

        //}
        //public void Login(string uname,string pwd)
        //{

        //}
    }
}
