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

        public Activity(string name, double caloriesPerMinute)
        {
            if (caloriesPerMinute < 0 || caloriesPerMinute > 100) 
                throw new ArgumentException("incorrect value of energy coast", nameof(caloriesPerMinute));
            Name = name;
            CaloriesPerMinute = caloriesPerMinute;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
