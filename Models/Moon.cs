namespace planetvacation.Models
{
    class Moon : Location
    {
        public Planet HomePlanet { get; set; }






        public Moon(string name) : base(name)
        {
        }
    }
}