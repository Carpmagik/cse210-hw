using System;


public static class Loading
{
    public static void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime endTime =
            DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);

            Thread.Sleep(200);

            Console.Write("\b \b");

            i++;
        }
    }

    public static void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);

            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }
}