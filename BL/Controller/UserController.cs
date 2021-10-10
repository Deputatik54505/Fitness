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
        public bool isNewUser { get; } = false;
        const string FILE_NAME = "user.dat";

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

       
        public void UpdateUserData(double weight, int height, int age, bool gender)
        {
            activeUser.AddСharacteristics(weight,height,age,gender);
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
        private List<User> Load()
        {
            return Load<List<User>>(FILE_NAME) ?? new List<User>();
        }

    }
}
