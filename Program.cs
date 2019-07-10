using System;

namespace planetvacation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Welcome to the Galaxy. What is your name?");
            string name = Console.ReadLine();
            App app = new App(name);
            app.Run();
            //Prompt for Restart?

        }
    }
}
