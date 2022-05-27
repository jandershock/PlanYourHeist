using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            TeamMember randomMember = new TeamMember();
            Console.WriteLine();
            randomMember.PrintInfo();
        }
    }
}
