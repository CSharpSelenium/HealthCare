using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TY_Selenium_UnitTest.Commons;

namespace TY_Selenium_UnitTest.POMClasses.AdminModule
{
   public class Admin_Doctor_Page
    {
        [FindsBy(How =How.XPath,Using = "//span[text()='Doctor']")]
        private IWebElement DoctorLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Add Doctor')]")]
        private IWebElement AddDoctorbtn { get; set; }
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement Doctornametbx { get; set; }
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Doctoremailtbx { get; set; }
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Doctorpasswordtbx { get; set; }
        [FindsBy(How = How.Name, Using = "address")]
        private IWebElement Doctoraddresstbx { get; set; }
        [FindsBy(How = How.Name, Using = "phone")]
        private IWebElement Doctorphonetbx { get; set; }

        [FindsBy(How = How.Name, Using = "department_id")]
        private IWebElement Doctordepartment_iddropdwn { get; set; }
        [FindsBy(How = How.XPath, Using = "//tr")]
        private IList<IWebElement> listofelementsbeforeintbl { get; set; }
        [FindsBy(How = How.XPath, Using = "//tr")]
        private IList<IWebElement> listofelementsaftereintbl { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Save')]")]
        private IWebElement DoctorSaveBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "(//a[contains(.,'Edit')])[2]")]
        private IWebElement DoctorEditBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Update')]")]
        private IWebElement DoctorUpdateBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='toast-message']")]
        private IWebElement UpdateSuceesMsg { get; set; }
        [FindsBy(How = How.XPath, Using = "(//a[contains(.,'Delete')])[1]")]
        private IWebElement DoctorDeletebtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[text()='Delete']")]
        private IWebElement DoctorDeleteConfirmbtn { get; set; }
        public Admin_Doctor_Page()
        {
            PageFactory.InitElements(Browser.driver, this);

        }

        public bool Admin_Add_Doctor(string name,string email,string password,string address,int phoneNo,string deptid)
        {
            Thread.Sleep(2000);
            DoctorLink.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            int recordsbeforeadding= listofelementsbeforeintbl.Count;
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            AddDoctorbtn.Click();
            Thread.Sleep(3000);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctornametbx.SendKeys(name);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctoremailtbx.SendKeys(email);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctorpasswordtbx.SendKeys(password);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctoraddresstbx.SendKeys(address);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctorphonetbx.SendKeys(phoneNo.ToString());
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            HandleDropdown.SelectByText(Doctordepartment_iddropdwn, deptid);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            DoctorSaveBtn.Click();
            Thread.Sleep(3000);
            int recordsafteradding=   listofelementsaftereintbl.Count;

            if(recordsafteradding>recordsbeforeadding)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Admin_Edit_Doctor(string name, string email, string password, string address, int phoneNo, string deptid)
        {
            Thread.Sleep(2000);
            DoctorLink.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            DoctorEditBtn.Click();
            Thread.Sleep(3000);
            Doctornametbx.Clear();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctornametbx.SendKeys(name);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctoremailtbx.Clear();
            Doctoremailtbx.SendKeys(email);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctoraddresstbx.SendKeys(address);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctorphonetbx.SendKeys(phoneNo.ToString());
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            HandleDropdown.SelectByText(Doctordepartment_iddropdwn, deptid);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            DoctorUpdateBtn.Click();
            string msg = UpdateSuceesMsg.Text;
            if (msg.Contains("Updated Successfuly"))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool Admin_Edit_Doctor(string name)
        {
            Thread.Sleep(2000);
            DoctorLink.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            int recordsbeforeadding = listofelementsbeforeintbl.Count;
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            AddDoctorbtn.Click();
            Thread.Sleep(3000);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctornametbx.SendKeys(name);
           
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            DoctorSaveBtn.Click();
            Thread.Sleep(3000);
            int recordsafteradding = listofelementsaftereintbl.Count;

            if (recordsafteradding > recordsbeforeadding)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Admin_Edit_Doctor(string name, string email)
        {
            Thread.Sleep(2000);
            DoctorLink.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            int recordsbeforeadding = listofelementsbeforeintbl.Count;
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            AddDoctorbtn.Click();
            Thread.Sleep(3000);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctornametbx.SendKeys(name);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctoremailtbx.SendKeys(email);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            DoctorSaveBtn.Click();
            Thread.Sleep(3000);
            int recordsafteradding = listofelementsaftereintbl.Count;

            if (recordsafteradding > recordsbeforeadding)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Admin_Edit_Doctor(string name, string email, string password)
        {
            Thread.Sleep(2000);
            DoctorLink.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            int recordsbeforeadding = listofelementsbeforeintbl.Count;
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            AddDoctorbtn.Click();
            Thread.Sleep(3000);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctornametbx.SendKeys(name);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctoremailtbx.SendKeys(email);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctorpasswordtbx.SendKeys(password);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
         
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            DoctorSaveBtn.Click();
            Thread.Sleep(3000);
            int recordsafteradding = listofelementsaftereintbl.Count;

            if (recordsafteradding > recordsbeforeadding)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Admin_Edit_Doctor(string name, string email, string password, string address)
        {
            Thread.Sleep(2000);
            DoctorLink.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            int recordsbeforeadding = listofelementsbeforeintbl.Count;
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            AddDoctorbtn.Click();
            Thread.Sleep(3000);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctornametbx.SendKeys(name);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctoremailtbx.SendKeys(email);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctorpasswordtbx.SendKeys(password);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctoraddresstbx.SendKeys(address);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
         
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            DoctorSaveBtn.Click();
            Thread.Sleep(3000);
            int recordsafteradding = listofelementsaftereintbl.Count;

            if (recordsafteradding > recordsbeforeadding)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Admin_Edit_Doctor(string name, string email, string password, int phoneNo, string deptid)
        {
            Thread.Sleep(2000);
            DoctorLink.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            int recordsbeforeadding = listofelementsbeforeintbl.Count;
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            AddDoctorbtn.Click();
            Thread.Sleep(3000);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctornametbx.SendKeys(name);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctoremailtbx.SendKeys(email);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Doctorpasswordtbx.SendKeys(password);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
         
            Doctorphonetbx.SendKeys(phoneNo.ToString());
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            HandleDropdown.SelectByText(Doctordepartment_iddropdwn, deptid);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            DoctorSaveBtn.Click();
            Thread.Sleep(3000);
            int recordsafteradding = listofelementsaftereintbl.Count;

            if (recordsafteradding > recordsbeforeadding)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Admin_Delete_Doctor()
        {
            DoctorLink.Click();
            Thread.Sleep(2000);
            int beforedeleting = listofelementsbeforeintbl.Count;
            DoctorDeletebtn.Click();
            Thread.Sleep(2000);
            DoctorDeleteConfirmbtn.Click();
            Thread.Sleep(2000);
            int afterdeleting = listofelementsaftereintbl.Count;
            if (afterdeleting < beforedeleting)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
