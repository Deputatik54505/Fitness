using BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace BL.Controller
{
    public class UserController
    {
        public User User { get; }

        public UserController(string name, int age, double weight,
                    int height, bool gender)
        {
            User user = new User(name, age, weight, height, gender);
            User = user;
        }
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                User = formatter.Deserialize(fileStream) as User;
            }
        }

/// <summary>
/// Save user data
/// </summary>
public void Save() 
        {
            var formatter = new BinaryFormatter();

            using (var fileStream = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream,User);
            }
        }

    }
}
