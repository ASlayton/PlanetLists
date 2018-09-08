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
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
