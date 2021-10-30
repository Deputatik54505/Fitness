using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Controller.Tests
{
    [TestClass()]
    public class EatingControllerTests
    {
        [TestMethod()]
        public void AddFoodToEatingTest()
        {
            var rnd = new Random();
            var userController = new UserController(Guid.NewGuid().ToString());
            userController.UpdateUserData(rnd.Next(50,150),rnd.Next(150,200),rnd.Next(15,99), true, 1.5);
            var eatingController = new EatingController(userController);
            var foodName = Guid.NewGuid().ToString();
            var prots = rnd.Next(0, 30);
            eatingController.CreateFood(foodName, prots, rnd.Next(0, 30), rnd.Next(0, 30), rnd.Next(0, 100));
            eatingController.AddFoodToEating(foodName,rnd.Next(100,1000));

            Assert.AreEqual(eatingController.Eatings[0].Prots,prots);
        }
    }
}