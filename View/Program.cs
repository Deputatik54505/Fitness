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

            UserController user = new UserController(name);

            if (user.isNewUser)
            {

                // TODO: сделать user-frendly проверку
                Console.WriteLine("Input weight:");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Input height:");
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine("Input age:");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("You are female. It is true or false");
                bool gender = bool.Parse(Console.ReadLine());

                user.AddСharacteristics(weight,height,age,gender);
            }



            Console.WriteLine(user.activeUser);
            Console.ReadLine();
        }
    }
}
