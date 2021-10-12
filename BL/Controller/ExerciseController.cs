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


        /// <summary>
        /// Add new exercise
        /// </summary>
        /// <param name="activity">Kind of activity</param>
        /// <param name="duration">Duration of activity</param>
        public void AddExercise(Activity activity, double duration)
        {
            var act = Activities.SingleOrDefault(a=>a.Name==activity.Name);
            if (act == null)
            {
                Activities.Add(activity);
            }
            var exercise = new Exercise(activity,duration,User);
            Exercises.Add(exercise);
            Save();
        }



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
