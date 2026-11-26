using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");

        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");

        Console.Write("Select a choice from the menu:");

        string choice = Console.ReadLine();
        Console.WriteLine($"You selected option {choice}");

        if (choice == "1")
        {
            BreathingActivity breathing = new BreathingActivity();
            breathing.Run();
        }

        else if (choice == "2")
        {
            ReflectionActivity reflecting = new ReflectionActivity();
            reflecting.Run();
        }

        else if (choice == "3")
        {
            ListingActivity listing = new ListingActivity();
            listing.Run();

        }

        else if (choice == "4")
        {
            Console.WriteLine("Goodbye!");
        }
    }

}