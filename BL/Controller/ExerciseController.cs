using BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.Controller
{
    /// <summary>
    /// Controller of exercise
    /// </summary>
    public class ExerciseController:ControllerBase
    {
        #region variabels
        User User { get; }
        public List<Exercise> Exercises;
        public List<Activity> Activities;
        const string EXERCISES_FILNAME = "exercises.dat";
        const string ACTIVITIES_FILNAME = "activities.dat";
        #endregion


      
        public bool AddExercise(string activityName, double duration)
        {
            var activity = Activities.SingleOrDefault(a=>a.Name== activityName);
            if (activity == null)
                return false
            var exercise = new Exercise(activity,duration,User);
            Exercises.Add(exercise);
            Save();
        }

        //TODO: создать базовый класс для приемов пищи и упражнений

        /// <summary>
        /// Constructor with only name
        /// </summary>
        /// <param name="user"></param>
        public ExerciseController(User user)
        {
            User = user ?? throw new ArgumentNullException("User cant be null", nameof(user));
            Exercises = LoadExercises();
            Activities = LoadActivityes();
        }
        List<Exercise> LoadExercises()
        {
            return Load<List<Exercise>>(EXERCISES_FILNAME) ?? new List<Exercise>();
        }
        List<Activity> LoadActivityes()
        {
            return Load<List<Activity>>(ACTIVITIES_FILNAME) ?? new List<Activity>();
        }
        
        void Save()
        {
            Save<List<Exercise>>(EXERCISES_FILNAME,Exercises);
            Save<List<Activity>>(ACTIVITIES_FILNAME,Activities);
        }
    }
}
