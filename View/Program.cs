using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
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
            var eatingController = new EatingController(userController.activeUser);
            var exerciseController = new ExerciseController(userController.activeUser);
            Console.WriteLine("Q - exit, E - add eating, A - add activity");
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.A:
                    break;
                case ConsoleKey.E:
                    AddEating();
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
                    break;

            }


            void AddEating()
            {
                Console.WriteLine("Input food name");
                var foodName = Console.ReadLine();
                var weight = Parser<double>("weight of food");

                if (!eatingController.AddFoodToEating(foodName, weight))
                {
                    var proteins = Parser<double>("proteins");
                    var fats = Parser<double>("fats");
                    var carbs = Parser<double>("carbs");
                    var calories = Parser<double>("calories");
                    eatingController.CreateFood(foodName,proteins,fats,carbs,calories);
                    eatingController.AddFoodToEating(foodName, weight);
                }
                Console.WriteLine(eatingController.Foods[0]);
            }
            void AddAct()
            {
                Console.WriteLine("input activity name");
                var actName = Console.ReadLine();

            }

            T Parser<T>(string name)
            {
                while (true)
                {
                    Console.WriteLine($"Input {name}");
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
