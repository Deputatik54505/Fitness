using BL.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace BL.Controller.Tests
{
    [TestClass()]
    public class ExerciseControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var userName = Guid.NewGuid().ToString();
            var activityName = Guid.NewGuid().ToString();
            var rnd = new Random();
            var userController = new UserController(userName);
            var exerciseController = new ExerciseController(userController.activeUser);
            userController.UpdateUserData(100, 150, 30, true, 1.5);
            exerciseController.CreateActivity(activityName, rnd.Next(2, 99));
            exerciseController.AddExercise(activityName,rnd.Next(2,100));

            
            
        }
    }
}