using System;
using System.Threading;
using planetvacation.Models;

namespace planetvacation
{
    class App
    {
        private Location currentLocation;
        private bool running = true;

        public string Name { get; set; }
        public void Setup()
        {
            //Planets
            Planet mercury = new Planet("Mercury");
            Planet venus = new Planet("Venus");
            Planet earth = new Planet("Earth");
            Planet mars = new Planet("Mars");
            Planet jupiter = new Planet("Jupiter");
            Planet saturn = new Planet("Saturn");
            Planet uranus = new Planet("Uranus");
            Planet neptune = new Planet("Neptune");
            Planet pluto = new Planet("Pluto");

            //Moons
            Moon luna = new Moon("Luna", earth);
            Moon phobos = new Moon("Phobos", mars);
            Moon deimos = new Moon("Deimos", mars);
            Moon europa = new Moon("Europa", jupiter);
            Moon titan = new Moon("Titan", saturn);

            //Relationships
            mercury.AddNextPlanet(venus);
            venus.AddNextPlanet(earth);
            earth.AddNextPlanet(mars);
            mars.AddNextPlanet(jupiter);
            jupiter.AddNextPlanet(saturn);
            saturn.AddNextPlanet(uranus);
            uranus.AddNextPlanet(neptune);
            neptune.AddNextPlanet(pluto);

            currentLocation = earth;
        }

        public void Run()
        {
            while (running)
            {
                currentLocation.Print();
                System.Console.WriteLine("Type 'sign' to sign guestbook");
                currentLocation.PrintOptions();
                string input = Console.ReadLine().ToLower();
                System.Console.Write("Processing");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    Console.Write('.');
                }

                Console.Clear();
                string[] inputs = input.Split(' ');
                string command = inputs[0];
                string option = "";
                if (inputs.Length > 1)
                {
                    option = inputs[1];
                }
                switch (command)
                {
                    case "go":
                        currentLocation = currentLocation.Go(option);
                        break;
                    case "sign":
                        currentLocation.Sign(Name);
                        break;
                }
            }
        }

        public App(string name)
        {
            Name = name;
            Setup();
        }
    }
}