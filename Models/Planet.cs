using System;
using System.Collections.Generic;

namespace planetvacation.Models
{
    class Planet : Location
    {
        public Planet Next { get; private set; }

        public Planet Previous { get; private set; }

        public Dictionary<string, Moon> Moons { get; set; }

        public void AddNextPlanet(Planet next)
        {
            Next = next;
            next.AddPreviousPlanet(this);
        }

        public void AddPreviousPlanet(Planet previous)
        {
            Previous = previous;
        }
        public void AddMoon(Moon moon)
        {
            Moons.Add(moon.Name.ToLower(), moon);
        }

        public override void PrintOptions()
        {
            System.Console.Write("type 'go next', 'go previous', or 'go' and one of the following moon names: ");
            foreach (var moon in Moons)
            {
                Console.Write(moon.Key + " : ");
            }
        }

        public override Location Go(string dir)
        {
            switch (dir)
            {
                case "previous":
                    if (Previous != null) return Previous;
                    return this;
                case "next":
                    if (Next != null) return Next;
                    return this;

                default:
                    return GoToMoon(dir);

            }
        }

        private Location GoToMoon(string dir)
        {
            if (Moons.ContainsKey(dir))
            {
                return Moons[dir];
            }
            Console.WriteLine("Invalid location.");
            return this;
        }

        public Planet(string name) : base(name)
        {
            Moons = new Dictionary<string, Moon>();
        }
    }
}