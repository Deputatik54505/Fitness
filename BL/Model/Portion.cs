using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Model
{
    /// <summary>
    /// Portion of food 
    /// </summary>
    [Serializable]
    public class Portion
    {
        public FoodModel Food { get; }
        public double Weight { get; }
        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="food"> food, you want to add </param>
        /// <param name="weight"> weight of portion </param>
        public Portion(FoodModel food,double weight)
        {
            Food = food ?? throw new ArgumentNullException("food can`t be null", nameof(food));
            Weight = weight;
        }
    }
}
