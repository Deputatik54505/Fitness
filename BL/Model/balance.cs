using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Model
{
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
        public void Activity(double calories)
        {
            Calories += calories;
        }
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
