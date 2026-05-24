using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        int score = 0;

        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {score} points.");

            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Goal Types:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                Console.Write("Which type of goal? ");
                string goalType = Console.ReadLine();

                Console.Write("Goal name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (goalType == "1")
                {
                    goals.Add(
                        new SimpleGoal(name, description, points)
                    );
                }

                else if (goalType == "2")
                {
                    goals.Add(
                        new EternalGoal(name, description, points)
                    );
                }

                else if (goalType == "3")
                {
                    Console.Write("How many times to do? ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(
                        new ChecklistGoal(
                            name,
                            description,
                            points,
                            target,
                            bonus
                        )
                    );
                }
            }

            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Your Goals:");

                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
                }
            }

            else if (choice == "3")
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(score);

                    foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.SaveGoal());
                    }
                }

                Console.WriteLine("Goals saved.");
            }

            else if (choice == "4")
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();

                string[] lines = File.ReadAllLines(filename);

                score = int.Parse(lines[0]);

                goals.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split("|");

                    string type = parts[0];

                    if (type == "SimpleGoal")
                    {
                        goals.Add(
                            new SimpleGoal(
                                parts[1],
                                parts[2],
                                int.Parse(parts[3])
                            )
                        );
                    }

                    else if (type == "EternalGoal")
                    {
                        goals.Add(
                            new EternalGoal(
                                parts[1],
                                parts[2],
                                int.Parse(parts[3])
                            )
                        );
                    }

                    else if (type == "ChecklistGoal")
                    {
                        goals.Add(
                            new ChecklistGoal(
                                parts[1],
                                parts[2],
                                int.Parse(parts[3]),
                                int.Parse(parts[4]),
                                int.Parse(parts[5])
                            )
                        );
                    }
                }

                Console.WriteLine("Goals loaded.");
            }

            else if (choice == "5")
            {
                Console.WriteLine();
                Console.WriteLine("Goals:");

                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
                }

                Console.Write("Which goal did you complete? ");
                int goalNumber = int.Parse(Console.ReadLine());

                int pointsEarned =
                    goals[goalNumber - 1].RecordEvent();

                score += pointsEarned;

                Console.WriteLine();
                Console.WriteLine($"You earned {pointsEarned} points!");
            }
        }
    }
}