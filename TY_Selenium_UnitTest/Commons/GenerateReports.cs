using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RelevantCodes.ExtentReports;

namespace TY_Selenium_UnitTest.Commons
{
   public class GenerateReports
    {
        public static ExtentReports report;
        public static ExtentTest test;

        [OneTimeSetUp]
        public static void ReportsInit()
        {
            report = new ExtentReports(@"C:\Users\Dwarkesh\source\repos\TY_Selenium_UnitTest\TY_Selenium_UnitTest\Reports\"+TestContext.CurrentContext.Test.ClassName+".html");

        }
        [OneTimeTearDown]
        public static void ReportEnd()
        {
            report.Flush();
            report.Close();
        }
    }
}
