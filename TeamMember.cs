using System;

namespace PlanYourHeist
{

    public class TeamMember
    {
        private uint _skillLevel;
        private float _courageFactor;

        public string Name { get; }

        // Helper function for validating correct courage factor user input
        private bool isValidCourageFactor(string s, out float validatedFloat)
        {
            float f = -1;

            if (float.TryParse(s, out f))
            {
                if (f >= 0.0 && f <= 2.0)
                {
                    validatedFloat = f;
                    return true;
                }
            }

            // Valid float type but its value is outside the range of 0.0 - 2.0
            validatedFloat = -1;
            return false;
        }

        public TeamMember()
        {
            Console.WriteLine("\nEnter Team Member Stats");
            Console.WriteLine("-----------------------");

            // Get team member name
            Console.Write("Name? ");
            Name = Console.ReadLine();

            // Get valid team member skill level
            do
            {
                Console.Write("Skill Level? ");
            } while (!uint.TryParse(Console.ReadLine(), out _skillLevel));

            // Get valid team member courage factor
            do
            {
                Console.Write("Courage Factor (0.0 - 2.0)? ");
            } while (!isValidCourageFactor(Console.ReadLine(), out _courageFactor));
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} has a skill level of {_skillLevel} and a courage factor of {_courageFactor}");
        }
    }
}