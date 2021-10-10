using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Model
{
    [Serializable]
    public class Portion
    {
        public FoodModel Food { get; }
        public double Weight { get; }

        public Portion(FoodModel food,double weight)
        {
            Food = food ?? throw new ArgumentNullException("food can`t be null", nameof(food));
            Weight = weight;
        }
    }
}
