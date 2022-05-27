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

            int bankDifficultyLevel = 100;
            int teamSkill = 0;

            foreach(TeamMember member in team)
            {
                teamSkill += (int) member.SkillLevel;
            }

            if (teamSkill >= bankDifficultyLevel)
            {
                Console.WriteLine("Heist successful!");
            }
            else
            {
                Console.WriteLine("Heist failed!");
            }
        }
    }
}
