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
        public int Age {  get; private set; }
        public double Weight { get; private set; }
        public int Height { get; private set; }

        /// <summary>
        /// true - female
        /// false - male
        /// </summary>
        public bool Gender { get; private  set; }
        /// <summary>
        /// start by 1.2 
        /// end  by 2.0
        /// </summary>
        public double ActCoeff { get; private set; }

        /// <summary>
        /// how much user shud eat or act to be great)
        /// </summary>
        public Balance Balance { get; private set; }
        
        #endregion

       
        public User(string name)
        {
            Name = name ?? throw new ArgumentNullException("name cant be null", nameof(name));
            
        }

        /// <summary>
        /// It is first step after create user
        /// </summary>
        /// <param name="weight"> (30;200) </param>
        /// <param name="height"> (10;100) </param>
        /// <param name="age"></param>
        /// <param name="gender"> true - female 
        ///  false - male </param>
        /// <param name="actCoeff"> 1.2 to 2.0</param>
        public void AddСharacteristics(double weight, int height, int age, bool gender, double actCoeff)
        {
            if (age < 10 || age > 100)
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
        /// <summary>
        /// Dont use that. it dont save any changes
        /// 
        /// discards the user’s balance
        /// </summary>
        public void ThrowBalance()
        {
            var genderfluens = 0;
            if (Gender)
                genderfluens = -161;
            else
                genderfluens = 5;
            Balance = new Balance(Math.Round((Weight * 10 + Height * 6.25 - Age * 5 + genderfluens) * ActCoeff,1),
                Math.Round(1.5 * Weight,1),
                Math.Round(4 * Weight,1),
                Math.Round(0.7 * Weight,1));
        }

        public override string ToString()
        {
            return Name + " " + Balance;
        }
       
    }
}
