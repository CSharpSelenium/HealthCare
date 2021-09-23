using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TY_Selenium_UnitTest.Commons
{
    public  class HandleAlert
    {
        public static void AcceptAlert()
        {
            IAlert alert = Browser.driver.SwitchTo().Alert();
            alert.Accept();

        }
        public static void DismissAlert()
        {
            IAlert alert = Browser.driver.SwitchTo().Alert();
            alert.Dismiss();

        }
        public static void SenekeysToAlert(string keys)
        {
            IAlert alert = Browser.driver.SwitchTo().Alert();
            alert.SendKeys(keys);
        }
        public static string GetAlertText()
        {
            IAlert alert = Browser.driver.SwitchTo().Alert();
            return alert.Text;
           
        }
    } 
}
