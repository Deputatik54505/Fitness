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
        public string FoodName { get; private set; }
        public string Time { get; private set; }
        /// <summary>
        /// create an eating with 0 parametrs
        /// </summary>
        public Eating()
        {
            Prots = 0;
            Fats = 0;
            Carbs = 0;
            Calories = 0;
            Time = $"{DateTime.Now.Hour} : {DateTime.Now.Minute}";
        }
        /// <summary>
        /// add food to eating
        /// </summary>
        /// <param name="food"></param>
        /// <param name="weight"></param>
        public void AddFood(FoodModel food, double weight)
        {
            Prots += food.Proteins * weight;
            Fats += food.Fats * weight;
            Carbs += food.Carbs * weight;
            Calories += food.Calories * weight;
            FoodName = food.Name;
            Time = $"{DateTime.Now.Hour}: {DateTime.Now.Minute}";
        }
    }
}
