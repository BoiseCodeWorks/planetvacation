using System;
using System.Collections.Generic;

namespace planetvacation.Models
{
    abstract class Location
    {
        public string Name { get; set; }
        public List<string> GuestBook { get; set; }

        public virtual Location Go(string dir)
        {
            throw new NotImplementedException("Must provide Go method");
        }

        public virtual void PrintOptions()
        {
            System.Console.WriteLine("type 'go home' to return to the planet");
        }

        public void Print()
        {
            Console.WriteLine($"Welcome to {Name}!!!!!!!!!!!!!");
            Console.WriteLine("Previous visitors: ");
            int count = 1;
            foreach (var name in GuestBook)
            {
                Console.WriteLine($"{count}) {name}");
                count++;
            }
        }

        public void Sign(string str)
        {
            GuestBook.Add(str);
            Console.WriteLine("Thanks for signing the galactic guest book");
        }
        public Location(string name)
        {
            Name = name;
            GuestBook = new List<string>();
        }

    }
}