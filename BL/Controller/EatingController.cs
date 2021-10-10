using BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Controller
{
    [Serializable]
    public class EatingController : ControllerBase
    {
        #region Variabels
        public User User { get; }
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
        
        public void AddFood(FoodModel newFood)
        {
            Foods.Add(newFood);
            Save();
        }

        public void AddFoodToEating(FoodModel food, double weight)
        {
            var foodInList = Foods.SingleOrDefault(f=>f.Name==food.Name);
            if (foodInList == null)
                AddFood(food);
            Eating.AddFood(new Portion(food,weight));
            Save();
        }


        #region Save and load methods
        void Save()
        {
            Save<List<FoodModel>>(FOODS_FILE_NAME, Foods);
            Save<Eating>(FOODS_FILE_NAME, Eating);
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
