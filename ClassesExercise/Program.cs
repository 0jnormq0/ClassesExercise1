using System;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wheels = new Car();
            wheels.Make = "Chevy";
            wheels.Model = "Spark";
            wheels.Year = 2015;

            Console.WriteLine($"Your very first car is a {wheels.Make} { wheels.Model} {wheels.Year}!");

        }
    }
}
