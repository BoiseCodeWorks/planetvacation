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
        }

        public void AddPreviousPlanet(Planet previous)
        {
            Previous = previous;
        }

        public void AddMoon(Moon moon)
        {
            Moons.Add(moon.Name, moon);
        }


        public Planet(string name) : base(name)
        {
            Moons = new Dictionary<string, Moon>();
        }
    }
}