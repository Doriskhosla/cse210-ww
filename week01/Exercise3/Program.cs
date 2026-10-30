using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number?");
        // int magicNumber = int.Parse(Console.ReadLine());
       Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        // In this part of the code we use a do-while loop. while guess != magicNumber)

        while (guess != magicNumber)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}