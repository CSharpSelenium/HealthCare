using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TY_Selenium_UnitTest.Commons;
using TY_Selenium_UnitTest.POMClasses;
using TY_Selenium_UnitTest.POMClasses.AdminModule;

namespace TY_Selenium_UnitTest.TestRepo.AdminTests
{

    [TestFixture]
   public class Admin_Department_Tests:BaseTest
    {

        
        [Test]
        public void Admin_Add_Department_Test()
        {
            Admin_Department_Page Admin_Department_Page = new Admin_Department_Page();
            bool result= Admin_Department_Page.AddDepartment("Test Name", "Test Description");
            Assert.IsTrue(result);
        }

        [Test]
        public void Admin_Edit_Department_Test()
        {
            Admin_Department_Page Admin_Department_Page = new Admin_Department_Page();
            bool result= Admin_Department_Page.EditDepartment("Test Name ", "Test Description");
            Assert.IsTrue(result);
        }

        [Test]
        public void Admin_Delete_Department()
        {
            Admin_Department_Page admin_Department_Page = new Admin_Department_Page();
            bool result=admin_Department_Page.DeleteDepartment();
            Assert.IsTrue(result);
        }
        [Test]
        public void Admin_Search_Department()
        {
            Admin_Department_Page admin_Department_Page = new Admin_Department_Page();
            bool result = admin_Department_Page.SearchSpecificDepartment("cardiology");
            Assert.IsTrue(result);
        }

    }
}
