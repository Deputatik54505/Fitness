using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Model
{

    /// <summary>
    /// Activity model
    /// </summary>
    [Serializable]
    public class Activity
    {

        public string Name { get; }
        public double CaloriesPerMinute { get; }
        public double Duration { get; }
        public User User { get; }

        public Activity(string name, double caloriesPerMinute, double duration, User user)
        {
            if (caloriesPerMinute < 0 || caloriesPerMinute > 100) 
                throw new ArgumentException("incorrect value of energy coast", nameof(caloriesPerMinute));
            if (duration < 0)
                throw new ArgumentNullException("duration of exercise cant be less than 0");
            User = user ?? throw new ArgumentNullException("User cant be null", nameof(user));
            Duration = duration;
            Name = name;
            CaloriesPerMinute = caloriesPerMinute;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
