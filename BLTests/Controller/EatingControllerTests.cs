using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL.Controller;
using System;
using System.Collections.Generic;
using System.Text;
using BL.Model;

namespace BL.Controller.Tests
{
    [TestClass()]
    public class EatingControllerTests
    {
        [TestMethod()]
        public void AddFoodToEatingTest()
        {
            var userName = Guid.NewGuid().ToString();
            var foodName = Guid.NewGuid().ToString();
            var rnd = new Random();
            var userController = new UserController(userName);
            var eatingController = new EatingController(userController.activeUser);
            var food = new FoodModel(foodName, rnd.Next(1, 99), rnd.Next(1,99), rnd.Next(1, 99), rnd.Next(1, 399));

            eatingController.CreateFood(foodName, rnd.Next(1, 99), rnd.Next(1, 99), rnd.Next(1, 99), rnd.Next(1, 399));
            eatingController.AddFoodToEating(foodName,rnd.Next(100,1000));


            Assert.AreEqual(food.Calories, eatingController.Eating.Ration[0].Food.Calories);
            
        }
    }
}