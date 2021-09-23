using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TY_Selenium_UnitTest.Commons
{
    public class HandleDropdown
    {
         
        public static void SelectByIndex(IWebElement ele, int index)
        {
            SelectElement select  = new SelectElement(ele);
            select.SelectByIndex(index);


        }
        public static void SelectByValue(IWebElement ele, string value)
        {
            SelectElement select = new SelectElement(ele);
            select.SelectByValue(value);


        }
        public static void SelectByText(IWebElement ele, string text)
        {
            SelectElement select = new SelectElement(ele);
            select.SelectByText(text);

        }
    }
}
