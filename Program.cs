using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamMember> team = new List<TeamMember>();

            Console.WriteLine("Plan Your Heist!\n");

            Console.WriteLine("Add members to your team:");
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

            Console.WriteLine();
            Console.WriteLine($"Team has {team.Count} members");
            foreach(TeamMember member in team)
            {
                member.PrintInfo();
            }
        }
    }
}
