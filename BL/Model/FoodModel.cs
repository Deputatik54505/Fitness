using System;

namespace BL.Model
{

    /// <summary>
    /// Food model 
    /// </summary>
    [Serializable]
    public class FoodModel
    {
        #region Parametrs
        /// <summary>
        /// name of food
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// proteins per 1 gramm
        /// </summary>
        public double Proteins { get; }
        /// <summary>
        /// fats per 1 gramm
        /// </summary>
        public double Fats { get; }
        /// <summary>
        /// carbs per 1 gramm
        /// </summary>
        public double Carbs { get; }
        /// <summary>
        /// calories per 1 gramm
        /// </summary>
        public double Calories { get; }
        #endregion

        /// <summary>
        /// Constructor of food class, whith only name
        /// </summary>
        /// <param name="name"> Food name </param>
        public FoodModel(string name) : this(name, 0, 0, 0, 0) { }
        /// <summary>
        /// Constructor for food class, whith all of parameters
        /// </summary>
        /// <param name="name"> name of food</param>
        /// <param name="proteins"> proteins per 100 gramm </param>
        /// <param name="fats"> fats per 100 gramm </param>
        /// <param name="carbs"> carbs per 100 gramm </param>
        /// <param name="calories"> calories per 100 gramm </param>
        public FoodModel(string name,double proteins,double fats, double carbs,double calories)
        {
            #region Variable testing
            ParametrsTesting(proteins, "proteins");
            ParametrsTesting(fats, "fats");
            ParametrsTesting(carbs, "carbs");
            if (calories < 0)
                throw new ArgumentException("incorrect calories per 100 gramms");
#endregion

            Name = name ?? throw new ArgumentNullException("Product name can`t be null");
            Proteins = proteins / 100;
            Fats = fats / 100;
            Carbs = carbs / 100;
            Calories = calories / 100;
        }


        /// <summary>
        /// private method for shorten code 
        /// </summary>
        /// <param name="parameter"> parameter we will check </param>
        /// <param name="name"> name of parameter </param>
        void ParametrsTesting(double parameter, string name = "")
        {
            if (parameter > 100 || parameter < 0)
                throw new ArgumentException($"{name} per 100 grams cannot exceed 100, or less than 0", nameof(parameter));
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
