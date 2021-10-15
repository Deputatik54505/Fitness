using BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Controller
{

    public class EatingController : ControllerBase
    {
        #region Variabels
        User User { get; }
        public List<FoodModel> Foods { get; }
        public Eating Eating { get; }
        const string FOODS_FILE_NAME = "food.dat";
        const string EATINGS_FILE_NAME = "eatings.dat";
        #endregion

        public EatingController(User user)
        {
            User = user ?? throw new ArgumentNullException("User can`t be null");

            Foods = LoadFoodData();
            Eating = LoadEatingData();
        }


        public FoodModel CreateFood(string name, double proteins, double fats, double carbs, double calories)
        {
            var food = new FoodModel(name, proteins, fats, carbs, calories);
            Foods.Add(food);
            Save();
            return food;
        }
        public bool AddFoodToEating(string foodName, double weight)
        {
            var food = Foods.SingleOrDefault(f => f.Name == foodName);
            if (food == null)
                return false;
            Eating.AddFood(new Portion(food, weight));
            Save();
            this.User.Balance.Eating(food.Calories * weight, food.Proteins * weight, food.Carbs * weight, food.Fats * weight);
            return true;
        }


        #region Save and load methods
        void Save()
        {
            Save<List<FoodModel>>(FOODS_FILE_NAME, Foods);
            Save<Eating>(EATINGS_FILE_NAME, Eating);
        }
        List<FoodModel> LoadFoodData()
        {
            return Load<List<FoodModel>>(FOODS_FILE_NAME) ?? new List<FoodModel>();
        }
        Eating LoadEatingData()
        {
            return Load<Eating>(EATINGS_FILE_NAME) ?? new Eating(User);
        }
        #endregion
    }
}
