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
        /// <summary>
        /// gender of user (true - female, false - male)
        /// </summary>
        private bool Gender { get;  set; }
        private double ActCoeff { get;  set; }

        public double CaloriesBalance { get; private set; }
        
        #endregion

        /// <summary>
        /// constructor of user model
        /// </summary>
        /// <param name="name"> username </param>
        /// <param name="age"> user age </param>
        /// <param name="weight"> user weight </param>
        /// <param name="height"> user height </param>
        /// <param name="gender"> does user have a female metabolism or not (female - true , male - false) </param>
       
        /// <summary>
        /// constructor of user model, with only name
        /// </summary>
        /// <param name="name"></param>
        public User(string name)
        {
            Name = name ?? throw new ArgumentNullException("name cant be null", nameof(name));
        }


        /// <summary>
        /// Add standart characteristics to user
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
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
            var genderfluens = 0;
            if (Gender)
                genderfluens = -161;
            else
                genderfluens = 5;
            CaloriesBalance = - (Weight * 10 + Height * 6.25 - Age * 5 + genderfluens) * ActCoeff;
        }

        public void CBChange(double changing)
        {
            CaloriesBalance += changing;
        }
        
        public override string ToString()
        {
            return Name + " " + Age;
        }
       
    }
}
