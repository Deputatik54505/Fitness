using System;
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

            Console.WriteLine("input your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("input your weight");
            double weight = int.Parse(Console.ReadLine());

            Console.WriteLine("You have female metabolism, it is true or false?");
            bool gender = bool.Parse(Console.ReadLine());

            Console.WriteLine("input your height");
            int height = int.Parse(Console.ReadLine());

            UserController user = new UserController(name, age, weight, height, gender);
            user.Save();
        }
    }
}
