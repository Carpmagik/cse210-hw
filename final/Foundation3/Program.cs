using System;

class Program
{

    static void Main(string[] args)
    {
        OutdoorGathering outdoorEvent = new OutdoorGathering(
            "Picnic",
            "Enjoy the outdoors",
            "6/20/2026",
            "12:00 PM",
            "Dog Park",
            "Sunny"
        );

        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorEvent.GetShortDescription());

        Reception receptionEvent = new Reception(
            "Wedding Reception",
            "Celebrating the marriage.",
            "4/24/2026",
            "5:00 PM",
            "Church",
            "wedding@gmail.com"
        );
        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(receptionEvent.GetShortDescription());


        Lecture lectureEvent = new Lecture(
            "THistory Lecture",
            "A lecture on the latest trends in technology.",
            "6/10/2026",
            "3:00 PM",
            "Classroom",
            "Mr. Carlos",
            200
        );

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lectureEvent.GetShortDescription());
    }


}

