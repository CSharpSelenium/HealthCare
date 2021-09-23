using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TY_Selenium_UnitTest.Commons;

namespace TY_Selenium_UnitTest.POMClasses.AdminModule
{
  
   public class Admin_Department_Page
    {
        [FindsBy(How=How.XPath,Using = "//span[text()='Department']")]
        private IWebElement Departmentlink { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Add Department')]")]
        private IWebElement AddDepartmentbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//td//a[contains(.,'Edit')])[1]")]
        private IWebElement EditDepartmentbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//td//a[contains(.,'Delete')])[1]")]
        private IWebElement DeleteDepartmentbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Save')]")]
        private IWebElement SaveDepartmentbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(.,'Close')])[1]")]
        private IWebElement CloseDepartmentbtn { get; set; }
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement TitleDepartmenttbx { get; set; }
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement DescritionDepartmenttbx { get; set; }
        [FindsBy(How =How.XPath,Using = "//tr")]
        private IList<IWebElement>  listbeforeDepartmenttbl { get; set; }
        [FindsBy(How = How.XPath, Using = "//tr")]
        private IList<IWebElement> listafterDepartmenttbl { get; set; }
        [FindsBy(How =How.XPath,Using = "//button[contains(.,'Update')]")]
        private IWebElement updateDepartmentbtn { get; set; }

        [FindsBy(How =How.XPath,Using = "//div[@class='toast-message']")]
        private IWebElement UpdateSuceesMsg { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[text()='Delete']")]
        private IWebElement deleteDepartmentLink { get; set; }
        [FindsBy(How=How.XPath,Using = "//label[contains(text(),'Search:')]//input")]
        private IWebElement Searchtbx { get; set; }
        public Admin_Department_Page()
        {
            PageFactory.InitElements(Browser.driver,this);
        }
        public bool AddDepartment(string title, string Desc)
        {
            Departmentlink.Click();
            int before = listbeforeDepartmenttbl.Count;
           
            AddDepartmentbtn.Click(); 
            Thread.Sleep(3000);
            TitleDepartmenttbx.SendKeys(title+Keys.Tab);
            Thread.Sleep(3000);
            DescritionDepartmenttbx.SendKeys(Desc);
            SaveDepartmentbtn.Click();
            int after = listafterDepartmenttbl.Count;
            

            if (after > before)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EditDepartment(string title,string Desc)
        {
            Departmentlink.Click();
            Thread.Sleep(3000);
            EditDepartmentbtn.Click();
            Thread.Sleep(3000);
            TitleDepartmenttbx.Clear();
            TitleDepartmenttbx.SendKeys(title+Keys.Tab);
            Thread.Sleep(1000);
            DescritionDepartmenttbx.Clear();
            DescritionDepartmenttbx.SendKeys(Desc);
            Thread.Sleep(1000);
            updateDepartmentbtn.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3000);
            string msg=  UpdateSuceesMsg.Text;
            if(msg.Contains("Department Info Updated Successfuly"))
            {
                return true;

            }
            else
            {
                return false;
            }
            //Assignment
            //Instead of going for msg try on fecthing records

        }

        public bool DeleteDepartment()
        {
            
            Departmentlink.Click();
            Thread.Sleep(1000);
            int before = listbeforeDepartmenttbl.Count;
            Thread.Sleep(1000);
            DeleteDepartmentbtn.Click();
            Thread.Sleep(1000);
            deleteDepartmentLink.Click();
            Thread.Sleep(1000);
            int after = listafterDepartmenttbl.Count;

           if(before>after)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public bool SearchSpecificDepartment(string department)
        {
            Departmentlink.Click();
            Thread.Sleep(2000);
            Searchtbx.SendKeys(department);
            Thread.Sleep(2000);
          int count=  listafterDepartmenttbl.Count;
            if(count>1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void CloseDepartment()
        {
            CloseDepartmentbtn.Click();
        }

    }
}
