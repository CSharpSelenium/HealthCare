using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TY_Selenium_UnitTest.Commons;
using TY_Selenium_UnitTest.POMClasses.AdminModule;

namespace TY_Selenium_UnitTest.TestRepo.AdminTests
{

    [TestFixture]
   public class Admin_Doctor_Test:BaseTest
    {
        [Test]
        public void Admin_Add_Doctor()
        {
            Admin_Doctor_Page admin_Doctor_Page = new Admin_Doctor_Page();
            bool result=   admin_Doctor_Page.Admin_Add_Doctor("Test Name", "test@gmail.com","Test@123", "Test Address", 1234567890, "Cardiology");
            Assert.IsTrue(result);

        }
        [Test]
        public void Admin_Edit_Doctor()
        {
            Admin_Doctor_Page admin_Doctor_Page = new Admin_Doctor_Page();
            bool result = admin_Doctor_Page.Admin_Edit_Doctor("Test Name", "test@gmail.com", "Test@123", "Test Address", 1234567890, "Cardiology");
            Assert.IsTrue(result);

        }
        [Test]
        public void Admin_Delete_Doctor()
        {
            Admin_Doctor_Page admin_Doctor_Page = new Admin_Doctor_Page();
            bool result = admin_Doctor_Page.Admin_Delete_Doctor();
            Assert.IsTrue(result);

        }

    }
}
