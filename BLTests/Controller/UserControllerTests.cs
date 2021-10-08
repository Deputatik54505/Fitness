using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void SaveTest()
        {
            var userName = Guid.NewGuid().ToString();

            var controller = new UserController(userName);

            Assert.AreEqual(userName, controller.activeUser.Name);

        }


        [TestMethod()]
        public void AddСharacteristicsTest()
        {
            
        }
    }
}