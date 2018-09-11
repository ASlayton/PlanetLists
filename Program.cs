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

            List<string> mercuryProbes = new List<string>()
            {
                "Mariner 10",
                "Messenger"
            };

            List<string> venusProbes = new List<string>()
            {
                "Mariner 1",
                "Mariner 2",
                "Mariner 5",
                "Mariner 10",
                "Pioneer",
                "Galileo",
                "Magellan",
                "Cassini",
                "Parker Solar Probe"
            };


            List<string> marsProbes = new List<string>()
            {
                "Mariner 3",
                "Mariner 4",
                "Mariner 6",
                "Mariner 7",
                "Mariner 8",
                "Mariner 9",
                "Viking 1",
                "Viking 2",
                "Mars Observer",
                "Mars Pathfinder",
                "Sojourner",
                "Mars Global Surveyor",
                "Mars Climate Orbiter",
                "Mars Polar Lander",
            };

            List<string> jupiterProbes = new List<string>()
            {
                "Pioneer 10",
                "Pioneer 11",
                "Voyager 1",
                "Voyager 2",
                "Ulysses",
                "Galileo"
            };

            List<string> saturnProbes = new List<string>()
            {
                "Pioneer 11",
                "Voyager 1",
                "Voyager 1"
            };

            List<string> uranusProbes = new List<string>()
            {
                "Voyager 2"
            };

            List<string> neptuneProbes = new List<string>()
            {
                "Voyager 2"
            };

            Dictionary<string, List<string>> ProbeDictionary = new Dictionary<string, List<string>>
            {
                { "Mars", marsProbes },
                { "Mercury", mercuryProbes },
                { "Venus", venusProbes },
                { "Jupiter", jupiterProbes },
                { "Neptune", neptuneProbes },
                { "Saturn", saturnProbes },
                { "Uranus", uranusProbes }
            };

            foreach (var planet in planetList)
            {
                List<string> probesPlanets = new List<string>();
                foreach (var entry in ProbeDictionary)
                {
                    if (entry.Value.Contains(planet))
                    {
                        probesPlanets.Add(entry.Key);
                    }
                    string planetAndProbeOutput = string.Join(", ", probesPlanets);
                    Console.WriteLine($"{planet}: {planetAndProbeOutput}");
                }
            }


            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
