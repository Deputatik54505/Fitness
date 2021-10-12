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
        /// <summary>
        /// Name of activity
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Energy coast of activity per minute
        /// </summary>
        public double CaloriesPerMinute { get; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of activity</param>
        /// <param name="caloriesPerMinute">Energy coast of activity per minute</param>
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
