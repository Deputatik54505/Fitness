using System;

namespace BL.Model
{
    /// <summary>
    /// Model of user
    /// </summary>
    [Serializable]
    public class User
    {
        #region parameters
        public string Name { get; }
        private int Age {  get; set; }
        private double Weight { get; set; }
        private int Height { get;  set; }
        private bool Gender { get;  set; }
        private double ActCoeff { get;  set; }

        public balance Balance { get; private set; }
        
        #endregion

       
        public User(string name)
        {
            Name = name ?? throw new ArgumentNullException("name cant be null", nameof(name));
        }


        public void AddСharacteristics(double weight, int height, int age, bool gender, double actCoeff)
        {
            if (age <= 10 || age > 100)
                throw new ArgumentException("incorrect age:", nameof(age));
            if (weight < 30 || weight > 200)
                throw new ArgumentException("incorrect weight", nameof(weight));
            if (height < 50 || height > 300)
                throw new ArgumentException("incorrect height", nameof(height));
            if (actCoeff < 1.2 || actCoeff > 2)
                throw new ArgumentException("incorrect activity coeffecient", nameof(actCoeff));
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
            ActCoeff = actCoeff;

            ThrowBalance();
        }

        public void ThrowBalance()
        {
            var genderfluens = 0;
            if (Gender)
                genderfluens = -161;
            else
                genderfluens = 5;
            Balance = new balance((Weight * 10 + Height * 6.25 - Age * 5 + genderfluens) * ActCoeff, 1.5 * Weight, 4 * Weight, 0.7 * Weight);
        }

        public override string ToString()
        {
            return Name + " " + Balance;
        }
       
    }
}
