using System.Net.Security;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (level == 0)
            {
                Console.WriteLine("Game Over");
            }

            Console.WriteLine("Continue Code");



            int level = 10;

            if (level >= 10)
            {
                Console.WriteLine("Boss floor unlocked");
            }
            else if (level >= 5)
            {
                Console.WriteLine("The door opens.");
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }


            bool isPoisioned = true;

            if (isPoisioned == true)
            {
                Console.WriteLine("You died!");
            }
            else if (isPoisioned == false)
            {
                Console.WriteLine("You Lives");
            }


            Console.WriteLine("Your level (1-99): ");
            bool intputValid = int.TryParse(Console.ReadLine(), out int level);

            if (!intputValid || level < 1 || level > 99)
            {
                Console.WriteLine("Invalid Level.");
            }
            else if (level >= 10)
            {
                Console.WriteLine("Boss floor unlocked");
            }
            else if (level >= 5)
            {
                Console.WriteLine("The door opens.");
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }
        }
    }
}
