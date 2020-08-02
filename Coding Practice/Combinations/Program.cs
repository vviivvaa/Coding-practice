using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            bool isFound = false;
            int combinations = 0;

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                for (int j = firstNumber; j <= lastNumber; j++)
                {
                    combinations++;

                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} " +
                            $"({i} + {j} = {magicNumber})");

                        isFound = true;

                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
