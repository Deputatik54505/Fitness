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
        public void ConstructorTest()
        {
            var userName = Guid.NewGuid().ToString();

            var controller = new UserController(userName);

            Assert.AreEqual(userName, controller.activeUser.Name);

        }

        [TestMethod()]
        public void SaveTest()
        {

            var userName = Guid.NewGuid().ToString();


            var controller = new UserController(userName);
            controller.UpdateUserData(100, 150, 30, true, 1.5);
            var controller2 = new UserController(userName);

        }

        [TestMethod()]
        public void AddСharacteristicsTest()
        {
            var userName = Guid.NewGuid().ToString();


            var controller = new UserController(userName);
            controller.UpdateUserData(100,150,30,true,1.5);


        }
    }
}