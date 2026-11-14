using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the scripture reference.
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Create the scripture text.
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths";

        // Create the Scripture object.
        Scripture scripture = new Scripture(reference, text);

        // Continue until all words are hidden or the user quits.
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            // Display the scripture.
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to finish.");

            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }

            // Hide three random words.
            scripture.HideRandomWords(3);
        }

        Console.WriteLine("Thank you for using the Scripture Memorizer!");
    }
}