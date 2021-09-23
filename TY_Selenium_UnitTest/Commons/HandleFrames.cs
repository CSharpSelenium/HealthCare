using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TY_Selenium_UnitTest.Commons
{
   public class HandleFrames
    {

        public static void ByIndex(int index)
        {
            Browser.driver.SwitchTo().Frame(index);

        }
        public static void ByName(string name)
        {
            Browser.driver.SwitchTo().Frame(name);

        }
        public static void ByWebelement(IWebElement element)
        {
            Browser.driver.SwitchTo().Frame(element);

        }
    }
}
