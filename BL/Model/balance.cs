using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Model
{/// <summary>
 /// class of users dietary needs
 /// </summary>
    [Serializable]
    public class Balance
    {
        public double Calories { get; private set; }
        public double Proteins { get; private set; }
        public double Carbs { get; private set; }
        public double Fats { get; private set; }
        public Balance(double cals, double prots, double carbs, double fats)
        {
            Calories = cals;
            Proteins = prots;
            Carbs = carbs;
            Fats = fats;
        }
        /// <summary>
        /// change balance by activity
        /// </summary>
        /// <param name="calories"></param>
        public void Activity(double calories)
        {
            Calories += calories;
        }
        /// <summary>
        /// change balance by eating
        /// </summary>
        /// <param name="cals"></param>
        /// <param name="prots"></param>
        /// <param name="carbs"></param>
        /// <param name="fats"></param>
        public void Eating(double cals, double prots, double carbs, double fats)
        {
            Calories -= cals;
            Proteins -= prots;
            Carbs -= carbs;
            Fats -= fats;
        }

        public override string ToString()
        {
            return "Calories -" + Calories + "  "+ "Proteins -" + Proteins + "  " + "Carbs -" + Carbs + "  " + "Fats -" + Fats;
        }
    }
}
