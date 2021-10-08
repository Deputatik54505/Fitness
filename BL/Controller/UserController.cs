using BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace BL.Controller
{
    public class UserController
    {
        public List<User> Users { get; }
        public User activeUser { get; }
        public bool isNewUser { get; } = false;


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
        /// Load users data
        /// </summary>
        /// <returns></returns>
        private List<User> Load()
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                if (fileStream.Length > 0 && formatter.Deserialize(fileStream) is List<User> users)
                {
                    return users;
                }
                return new List<User>();
            }
        }

        public void AddСharacteristics(double weight, int height, int age, bool gender)
        {
            activeUser.Age = age;
            activeUser.Weight = weight;
            activeUser.Height = height;
            activeUser.Gender = gender;
            Save();

            // TODO: проверка входных значений
        }

        /// <summary>
        /// Save user data
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fileStream = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, Users);
            }
        }

    }
}
