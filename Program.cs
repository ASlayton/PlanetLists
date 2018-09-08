using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" }; 
            planetList.AddRange(lastTwoPlanets);
            List<string> otherPlanets = new List<string>() { "Earth", "Venus" };
            planetList.Insert(1, otherPlanets[0]);
            planetList.Insert(1, otherPlanets[1]);
            planetList.Add("Pluto");
            foreach (var item in planetList)
            {
                Console.WriteLine(item);
            }

            List<string> rockyPlanets = new List<string>();
            rockyPlanets = planetList.GetRange(0, 4);

            Console.WriteLine("The following are considered Rocky Planets:");
            foreach (var item in rockyPlanets)
            {
                Console.WriteLine(item);
            }

            planetList.Remove("Pluto");
            Console.WriteLine("Um, Pluto is not considered good enough to be on this list...");
            foreach (var item in planetList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
