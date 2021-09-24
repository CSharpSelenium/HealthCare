using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TY_Selenium_UnitTest.Commons;
using TY_Selenium_UnitTest.POMClasses.Accountant;

namespace TY_Selenium_UnitTest.TestRepo.AccountantTests
{
    [TestFixture]
    public class Accountant_Invoice_Tests : BaseTest
    {
        [Test]

        public void Accountant_AddInvoice_Test()
        {
            Accountant_Invoice_Page accountant_Invoice_Page = new Accountant_Invoice_Page();
            bool result=   accountant_Invoice_Page.Accountant_Add_Invoice("Test Title");
            Assert.IsTrue(result);

        }

    }
}
