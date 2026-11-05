using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromtUserName();
        int userNumber = PromtUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromtUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }


    static int PromtUserNumber()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }


    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }


    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of the number is {squaredNumber}.");
    }
}