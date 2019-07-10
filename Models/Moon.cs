using System;

namespace planetvacation.Models
{
    class Moon : Location
    {
        private Planet HomePlanet { get; set; }

        public override Location Go(string dir)
        {
            if (dir == "home")
            {
                return HomePlanet;
            }
            return this;
        }

        public Moon(string name, Planet planet) : base(name)
        {
            HomePlanet = planet;
            planet.AddMoon(this);
        }
    }
}