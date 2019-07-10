using System.Collections.Generic;

namespace planetvacation.Models
{
    class Planet : Location
    {
        public Planet Next { get; set; }

        public Planet Previous { get; set; }

        public Dictionary<string, Moon> Moons { get; set; }










        public Planet(string name) : base(name)
        {
        }
    }
}