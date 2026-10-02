/*
 * Student ID : 1690703812
 * Name       : Assignment02ฏ
 * Section    : 129D
 * No.        : 7
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string MaterialName = "Iron";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500;

            Console.WriteLine("------------------------------");
            Console.WriteLine("  -->  Welcome to Forge  <--  ");
            Console.WriteLine("------------------------------");

            Console.WriteLine("=> Iron Smelting 0.25 / Salvage 0.30");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            char menu;
            char.TryParse(Console.ReadLine(), out menu);

            Console.Write("=> How much would you like: ");
            double amount;
            bool amountOK = double.TryParse(Console.ReadLine(), out amount);

            if (amountOK && amount > 0 && amount <= MaxBatch)
            {
                if (menu == 'S' || menu == 's')
                {
                    double result = amount * SmeltRate;

                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {result:F2} {MaterialName} Ingot");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double result = amount / SalvageRate;

                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {result:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Error: invalid menu.");
                }
            }
            else
            {
                Console.WriteLine("Error: invalid amount.");
            }

        }
    }
}
