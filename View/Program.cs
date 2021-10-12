using System;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using BL.Controller;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.CreateSpecificCulture("en-uk");
            var resourseManager = new ResourceManager("View.Languages.LanguageEn-uk", typeof(Program).Assembly);
            
            Console.WriteLine(resourseManager.GetString("Hello"));
            Console.WriteLine(resourseManager.GetString("YourName"));
            string name = Console.ReadLine();

            UserController userController = new UserController(name);
            if (userController.isNewUser)
            {

                var weight = Parser<double>("weight");

                var height = Parser<int>("height");

                var age = Parser<int>("age");

                var gender = Parser<bool>("gendder (female - true; male - false)");

                userController.UpdateUserData(weight,height,age,gender);
            }

            Console.WriteLine(resourseManager.GetString("AskAct"));
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.A:
                    break;
                case ConsoleKey.E:
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
                    break;

            }



            Console.WriteLine(userController.activeUser);
            Console.ReadLine();

            void AddEating()
            {
                Console.WriteLine("");
                var eatingController = new EatingController(userController.activeUser);
                var food = Console.ReadLine();

            }
            
            T Parser<T>(string name)
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
