using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TY_Selenium_UnitTest.Commons
{
  public  class HandlingJavaScript
    {
        public static IJavaScriptExecutor javaScriptExecutor;
        public static void ExecuteNewScript(string script)
        {
            javaScriptExecutor = (IJavaScriptExecutor)Browser.driver;
            javaScriptExecutor.ExecuteScript(script);
        }
        public static void ExecuteNewScript(string script,IWebElement ele)
        {
            javaScriptExecutor = (IJavaScriptExecutor)Browser.driver;
            javaScriptExecutor.ExecuteScript(script, ele);

        }
    }
}
