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
        public int Age { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public bool Gender { get; set; }

        // TODO: исправить нарушение защиты
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
            #region variable testing
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
            #endregion

            Name = name ?? throw new ArgumentNullException("name cant be null", nameof(name));
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
        }

        public User(string name)
        {
            Name = name ?? throw new ArgumentNullException("name cant be null", nameof(name));
        }

        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
