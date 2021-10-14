using BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace BL.Controller
{
    public class UserController : ControllerBase
    {
        public List<User> Users { get; }
        public User activeUser { get; }
        /// <summary>
        /// bool variable to define a user without characteristics
        /// </summary>
        public bool isNewUser { get; } = false;

        const string FILE_NAME = "user.dat";

        /// <summary>
        /// Constructor 
        /// Try to find user by name in data
        /// If its fall, method create a new user with this name.
        /// </summary>
        /// <param name="name"></param>
        public UserController(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name cant be empty", nameof(name));
            }
            Users = Load();
            activeUser = Users.SingleOrDefault(u => u.Name == name);
            if (activeUser == null)
            {
                activeUser = new User(name);
                Users.Add(activeUser);
                isNewUser = true;
                Save();
            }
        }

        /// <summary>
        /// Method of adding features to a user that was created without them
        /// </summary>
        /// <param name="weight">Weight</param>
        /// <param name="height">Height</param>
        /// <param name="age">Age</param>
        /// <param name="gender">Gender</param>
        public void UpdateUserData(double weight, int height, int age, bool gender, double actCoeff)
        {
            activeUser.AddСharacteristics(weight,height,age,gender, actCoeff);
            Save();
        }


        /// <summary>
        /// Save user data
        /// </summary>
        public void Save()
        {
            Save<List<User>>(FILE_NAME, Users);
        }

        /// <summary>
        /// Load users data
        /// </summary>
        /// <returns></returns>
        List<User> Load()
        {
            return Load<List<User>>(FILE_NAME) ?? new List<User>();
        }

    }
}
