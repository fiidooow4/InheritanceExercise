using InheritanceExercise;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {



            // Create an object of your Bird class
            // Give values to your members using the object of your Bird class
            // Creatively display the class member values

            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.BeakLength = 3.5;

            Console.WriteLine("Bird Information:");
            Console.WriteLine($"Wing Color: {myBird.WingColor}");
            Console.WriteLine($"Can Fly: {myBird.CanFly}");
            Console.WriteLine($"Migrate: {myBird.DoMigrate}");
            Console.WriteLine($"Beak Length: {myBird.BeakLength}");

            Console.WriteLine();
        
         

            // Create an object of your Reptile class
            // Give values to your members using the object of your Reptile class
            // Creatively display the class member values

            var lizard = new Reptile();
            lizard.IsColdBlooded = true;
            lizard.IsScaly = true;
            lizard.Habitat = "Forest"; // Changed from Habital to Habitat for consistency
            lizard.CanGrowTail = true;

            Console.WriteLine("Reptile Information:");
            Console.WriteLine($"Cold-Blooded: {lizard.IsColdBlooded}");
            Console.WriteLine($"Scaly: {lizard.IsScaly}");
            Console.WriteLine($"Habitat: {lizard.Habitat}");
            Console.WriteLine($"Can Grow Tail: {lizard.CanGrowTail}");
















            
        }
    }
}