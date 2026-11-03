/*
* Student ID : 1690703812
* Name       : Lab08
* Section    : 129D
* No         : 7
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Part A

            {
                int[] numbers = { 12, 7, 30, 4, 19, 25, 9, 18 };

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
                }

                int sum = 0;
                float average;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                average = (float)sum / numbers.Length;
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Average: " + average);

                int maximum = numbers[0];
                int minimum = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > maximum)
                    {
                        maximum = numbers[i];
                    }
                    if (numbers[i] < minimum)
                    {
                        minimum = numbers[i];
                    }
                }
                Console.WriteLine("Maximum: " + maximum);
                Console.WriteLine("Minimum: " + minimum);

                Array.Sort(numbers);
                foreach (int n in numbers)
                {
                    Console.WriteLine("Sorted: " + n);
                }
            }

            // Part B

            {
                int[] numbers = { 3, 40, -5, 8, -2, 15, 22, -9 };

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
                }

                int sum = 0;
                float average;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                average = (float)sum / numbers.Length;
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Average: " + average);

                int maximum = numbers[0];
                int minimum = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > maximum)
                    {
                        maximum = numbers[i];
                    }
                    if (numbers[i] < minimum)
                    {
                        minimum = numbers[i];
                    }
                }
                Console.WriteLine("Maximum: " + maximum);
                Console.WriteLine("Minimum: " + minimum);

                Array.Sort(numbers);
                foreach (int n in numbers)
                {
                    Console.WriteLine("Sorted: " + n);
                }
            }
        }
    }

}
