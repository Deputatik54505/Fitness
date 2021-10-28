using System;

namespace BL.Model
{
    /// <summary>
    /// one meal
    /// </summary>
    [Serializable]
    public class Eating
    {


        public User User { get; }
        public double Prots { get; private set; }
        public double Fats { get; private set; }
        public double Carbs { get; private set; }
        public double Calories { get; private set; }
        public Eating()
        {
            Prots = 0;
            Fats = 0;
            Carbs = 0;
            Calories = 0;
        }

        public void AddFood(FoodModel food, double weight)
        {
            Prots += food.Proteins * weight;
            Fats += food.Fats * weight;
            Carbs += food.Carbs * weight;
            Calories += food.Calories * weight;
        }
    }
}
