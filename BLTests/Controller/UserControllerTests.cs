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
            controller.UpdateUserData(100, 150, 30, true);
            var controller2 = new UserController(userName);

            Assert.AreEqual(controller.activeUser.Weight, controller2.activeUser.Weight);
            Assert.AreEqual(controller.activeUser.Height, controller2.activeUser.Height);
            Assert.AreEqual(controller.activeUser.Name, controller2.activeUser.Name);
            Assert.AreEqual(controller.activeUser.Age, controller2.activeUser.Age);
            Assert.AreEqual(controller.activeUser.Gender, controller2.activeUser.Gender);
        }

        [TestMethod()]
        public void AddСharacteristicsTest()
        {
            var userName = Guid.NewGuid().ToString();


            var controller = new UserController(userName);
            controller.UpdateUserData(100,150,30,true);

            Assert.AreEqual(100,controller.activeUser.Weight);

        }
    }
}