using BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Controller
{
    public class EatingController : ControllerBase
    {
        #region Variabels
        UserController UserController { get; }
        public List<FoodModel> Foods { get; }
        public List<Eating> Eatings { get; }
         Dictionary<string, List<Eating>> eatingsData;
        const string FOODS_FILE_NAME = "food.dat";
        const string EATINGS_FILE_NAME = "eatings.dat";
        int eatingCount = 0;
        #endregion

        public EatingController(UserController userController)
        {
            UserController = userController ?? throw new ArgumentNullException("User can`t be null");

            Foods = LoadFoodData();
            Eatings = LoadEatingsData();
            
            
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
            Eatings.Add(new Eating());
            Eatings[Eatings.Count-1].AddFood(food,weight);
            Save();
            this.UserController.activeUser.Balance.Eating(food.Calories * weight, food.Proteins * weight, food.Carbs * weight, food.Fats * weight);
            UserController.Save();
            return true;
        }


        #region Save and load methods
        public void Save()
        {
            Save<List<FoodModel>>(FOODS_FILE_NAME, Foods);
            eatingsData[UserController.activeUser.Name] = Eatings;
            Save<Dictionary<String,List<Eating>>>(EATINGS_FILE_NAME,eatingsData);
        }
        List<FoodModel> LoadFoodData()
        {
            return Load<List<FoodModel>>(FOODS_FILE_NAME) ?? new List<FoodModel>();
        }
        List<Eating> LoadEatingsData()
        {
            eatingsData = Load<Dictionary<String, List<Eating>>>(EATINGS_FILE_NAME)?? new Dictionary<String, List<Eating>>();
            if (!eatingsData.ContainsKey(UserController.activeUser.Name))
                eatingsData.Add(UserController.activeUser.Name, new List<Eating>());
            return eatingsData[UserController.activeUser.Name];
        }
        #endregion
    }
}
