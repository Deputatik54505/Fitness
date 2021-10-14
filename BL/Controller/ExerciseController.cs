using BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Controller
{
    public class ExerciseController:ControllerBase
    {
        #region variabels
        User User { get; }
        public List<Exercise> Exercises;
        public List<Activity> Activities;
        const string EXERCISES_FILNAME = "exercises.dat";
        const string ACTIVITIES_FILNAME = "activities.dat";
        #endregion


        public Activity CreateActivity(string name, double caloriesPerMinute)
        {
            var act = new Activity(name,caloriesPerMinute);
            Activities.Add(act);
            Save();
            return act;
        }
        public bool AddExercise(string activityName, double duration)
        {
            var activity = Activities.SingleOrDefault(a=>a.Name== activityName);
            if (activity == null)
                return false;
            var exercise = new Exercise(activity,duration);
            Exercises.Add(exercise);
            this.User.CBChange(-exercise.Activity.CaloriesPerMinute*duration);
            Save();
            return true;
        }

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
