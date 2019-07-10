namespace planetvacation.Models
{
    class Moon : Location
    {
        private Planet HomePlanet { get; set; }

        public Planet Go() //virtual on Location
        {
            return HomePlanet;
        }

        public Moon(string name, Planet planet) : base(name)
        {
            HomePlanet = planet;
        }
    }
}