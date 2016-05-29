using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DinerMax3000.Business;

namespace DInerMax3000UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.Collections.Generic.List<Menu> resultMenus = NewMethod();
            int countBeforeSave = resultMenus[0].Items.Count;
            resultMenus[0].SaveNewMenuItem("UT_Name", "UT_Description", 10.00);
            resultMenus = Menu.GetAllMenus();
            int countAfterSave = resultMenus[0].Items.Count;
            Assert.IsTrue(countBeforeSave < countAfterSave);
        }

        private static System.Collections.Generic.List<Menu> NewMethod()
        {
            var resultMenus = Menu.GetAllMenus();
            Assert.IsTrue(resultMenus.Count > 0);
            return resultMenus;
        }
    }
}