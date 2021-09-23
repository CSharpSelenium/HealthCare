using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TY_Selenium_UnitTest.Commons
{
    public class Constants
    {
        public static string Browser = ConfigurationManager.AppSettings["BROWSER"];
        public static string Url = ConfigurationManager.AppSettings["URL"];
        public static string uname = ConfigurationManager.AppSettings["Username"];
        public static string pwd = ConfigurationManager.AppSettings["Password"];

    }
}
