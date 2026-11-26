public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine("Breathe out...");
            ShowCountdown(4);

            elapsedTime += 8;
        }

        DisplayEndingMessage();

    }
}