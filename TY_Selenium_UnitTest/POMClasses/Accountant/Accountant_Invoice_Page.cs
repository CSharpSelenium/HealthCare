using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TY_Selenium_UnitTest.Commons;

namespace TY_Selenium_UnitTest.POMClasses.Accountant
{
   public class Accountant_Invoice_Page
    {
        //span[text()='Select A Status']
        //span[text()='Paid']
        [FindsBy(How = How.XPath, Using = "//span[text()='Invoice']")]
        private IWebElement InvoiceLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[text()='Add Invoice']")]
        private IWebElement AddInvoiceLink { get; set; }
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement InvoiceNametbx { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[text()='Select A Patient']")]
        private IWebElement SelectPatientdd { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Tanvir Hasan')]")]
        private IWebElement SelectParticularPatient { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//span[text()='Select A Status']")]
        private IWebElement SelectPaymentdd { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[text()='Paid']")]
        private IWebElement SelectPaidStatus{ get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Create New Invoice')]")]
        private IWebElement CreateNewInvoivebtn { get; set; }


        public Accountant_Invoice_Page()
        {
            PageFactory.InitElements(Browser.driver, this);

        }

        public void Accountant_Add_Invoice(string InvTitle)
        {
            Thread.Sleep(2000);
            InvoiceLink.Click();
            Thread.Sleep(2000);
            AddInvoiceLink.Click();
            Thread.Sleep(2000);
            InvoiceNametbx.SendKeys(InvTitle);
            Thread.Sleep(2000);
            Actions actions = new Actions(Browser.driver);
            actions.Click(SelectPatientdd).Perform();
            Thread.Sleep(2000);

            actions.Click(SelectParticularPatient).Perform();
            Thread.Sleep(2000);
            actions.Click(SelectPaymentdd).Perform();
            Thread.Sleep(2000);
            actions.Click(SelectPaidStatus);
            Thread.Sleep(2000);
            CreateNewInvoivebtn.Click();

        }

    }
}
