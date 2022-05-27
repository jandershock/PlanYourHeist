using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamMember> team = new List<TeamMember>();
            Stats stats = new Stats();
            int bankDifficultyLevel;


            Console.WriteLine("Plan Your Heist!\n");

            do
            {
                Console.Write("Enter bank difficulty: ");
            } while (!int.TryParse(Console.ReadLine(), out bankDifficultyLevel));

            Console.WriteLine("\nAdd members to your team:");
            while (true)
            {
                Console.Write("\nName? ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                else
                {
                    team.Add(new TeamMember(name));
                }
            }

            Console.Write("\nEnter number of attempts: ");
            int numberOfAttempts;
            int.TryParse(Console.ReadLine(), out numberOfAttempts);


            int teamSkill = 0;

            foreach (TeamMember member in team)
            {
                teamSkill += (int)member.SkillLevel;
            }


            // Attempt loop
            for (int i = 0; i < numberOfAttempts; i++)
            {
                int luckValue = new Random().Next(-10, 11);
                bankDifficultyLevel += luckValue;

                Console.WriteLine($"\nTeam skill level: {teamSkill}\nBank difficulty level: {bankDifficultyLevel}");

                if (teamSkill >= bankDifficultyLevel)
                {
                    Console.WriteLine("Heist successful!");
                    stats.attemptRecord["Success"] += 1;
                }
                else
                {
                    Console.WriteLine("Heist failed!");
                    stats.attemptRecord["Fail"] += 1;
                }

            }

            stats.PrintReport();
        }
    }
}
