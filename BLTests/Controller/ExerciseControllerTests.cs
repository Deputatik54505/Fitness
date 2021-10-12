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
            var activity = new Activity(activityName,rnd.Next(2,200));


            exerciseController.AddExercise(activity,rnd.Next(0,100));

            Assert.AreEqual(exerciseController.Activities.First().Name, activity.Name);
            
        }
    }
}