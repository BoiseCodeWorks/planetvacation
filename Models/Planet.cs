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
        }

        public void AddPreviousPlanet(Planet previous)
        {
            Previous = previous;
        }

        public void AddMoon(Moon moon)
        {
            Moons.Add(moon.Name, moon);
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
            throw new NotImplementedException();
        }

        public Planet(string name) : base(name)
        {
            Moons = new Dictionary<string, Moon>();
        }
    }
}