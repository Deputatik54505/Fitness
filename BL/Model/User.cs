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
        public int Age { get; private set; }
        public double Weight { get; private set; }
        public int Height { get; private set; }
        public bool Gender { get; private set; }

        
        #endregion

        /// <summary>
        /// constructor of user model
        /// </summary>
        /// <param name="name"> username </param>
        /// <param name="age"> user age </param>
        /// <param name="weight"> user weight </param>
        /// <param name="height"> user height </param>
        /// <param name="gender"> does user have a female metabolism or not </param>
        public User(string name, int age, double weight,
                    int height, bool gender)
        {

            VariableTesting(weight, height, age);

            Name = name ?? throw new ArgumentNullException("name cant be null", nameof(name));
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
        }
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
        public void AddСharacteristics(double weight, int height, int age, bool gender)
        {
            VariableTesting(weight,height,age);
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
        }


        public override string ToString()
        {
            return Name + " " + Age;
        }
       
        void VariableTesting(double weight, int height, int age)
        {
            if (age <= 10 || age > 100)
            {
                throw new ArgumentException("incorrect age:", nameof(age));
            }
            if (weight < 30 || weight > 200)
            {
                throw new ArgumentException("incorrect weight", nameof(weight));
            }
            if (height < 50 || height > 300)
            {
                throw new ArgumentException("incorrect height", nameof(height));
            }
        }
    }
}
