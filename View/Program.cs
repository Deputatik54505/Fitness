using System;
using System.ComponentModel;
using BL.Controller;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            // TODO: Good morning/evening/night  ! 
            Console.WriteLine("input your name");
            string name = Console.ReadLine();

            UserController user = new UserController(name);

            if (user.isNewUser)
            {

                var weight = Input<double>("weight");

                var height = Input<int>("height");

                var age = Input<int>("age");

                var gender = Input<bool>("gendder (female - true; male - false)");

                user.UpdateUserData(weight,height,age,gender);
            }



            Console.WriteLine(user.activeUser);
            Console.ReadLine();
            T Input<T>(string name)
            {
                while (true)
                {
                    Console.WriteLine($"Input your {name}");
                    var value = Console.ReadLine();
                    try
                    {
                        return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(value);
                    }
                    catch
                    {
                        Console.WriteLine($"incorrect {name}");
                    }
                }
            }
        }
    }
}
