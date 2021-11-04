using BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Controller
{
    public class ExerciseController:ControllerBase
    {
        #region variabels
        UserController UserController { get; }
        public List<Exercise> Exercises { get; private set; }
        public Dictionary<int, List<Activity>> ActivitiesData { get; private set; }
        // int - type id
        // 0 - cardio, 1 - power training; 
        const string EXERCISES_FILNAME = "exercises.dat";
        const string ACTIVITIES_FILNAME = "activities.dat";
        #endregion


        public void CreateCardioActivity(string name, double caloriesPerMinute)
        {
            var act = new Activity(name,caloriesPerMinute);
            ActivitiesData[0].Add(act);
            Save();
        }
        public void CreatePowerActivity(string name, double caolriesPerTime)
        {
            var act = new Activity(name, caolriesPerTime);
            ActivitiesData[1].Add(act);
            Save();
        }
        public void AddExercise(string activityName, double duration,int typeId)
        {
            if (typeId == 0 || typeId == 1)
            {
                var activity = ActivitiesData[typeId].SingleOrDefault(a => a.Name == activityName);
                if (activity is null)
                    return;
                var exercise = new Exercise(activity, duration);
                Exercises.Add(exercise);
                this.UserController.activeUser.Balance.Activity(exercise.Activity.CaloriesPerMinute * duration);
                Save();
                UserController.Save();
            }
            
        }

        public ExerciseController(UserController userController)
        {
            UserController = userController ?? throw new ArgumentNullException("User cant be null", nameof(userController));
            Exercises = LoadExercises();
            ActivitiesData = LoadActivityes();
        }
        List<Exercise> LoadExercises()
        {
            return Load<List<Exercise>>(EXERCISES_FILNAME) ?? new List<Exercise>();
        }
        Dictionary<int, List<Activity>> LoadActivityes()
        {
            Dictionary<int, List<Activity>> emptyData = new Dictionary<int, List<Activity>>();
            emptyData.Add(0, new List<Activity>());
            emptyData.Add(1, new List<Activity>());
            return Load<Dictionary<int, List<Activity>>>(ACTIVITIES_FILNAME) ?? emptyData ;
        }
        
        public void Save()
        {
            Save<List<Exercise>>(EXERCISES_FILNAME,Exercises);
            Save<Dictionary<int, List<Activity>>>(ACTIVITIES_FILNAME, ActivitiesData);
        }
    }
}
