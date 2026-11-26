using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

    public ReflectionActivity()

        : base("Reflection",
    "This Activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }
    public void Run()

    {

        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder each of the following questions:");
        ShowSpinner(3);

        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            string question = GetRandomQuestion();

            Console.WriteLine();
            Console.Write($"> {question} ");
            ShowSpinner(5);

            elapsedTime += 5;
        }

        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    private string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

}

