using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when done.");
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        // Part 2: Compute the average
        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average of the numbers is: {average:F2}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

        // Part 3: Find the maximum and minimum numbers
        if (numbers.Count > 0)
        {
            int max = numbers[0];
            int min = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"The maximum number is: {max}");
            Console.WriteLine($"The minimum number is: {min}");
        }
        else
        {
            Console.WriteLine("No numbers were entered, so maximum and minimum cannot be determined.");
        }

        // Stretch Challenge: Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Stretch Challenge: Sort the list
        numbers.Sort();
        Console.WriteLine("The sorted list of numbers in ascending order is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}