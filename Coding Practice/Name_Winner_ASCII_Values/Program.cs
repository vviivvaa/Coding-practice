using System;

namespace Name_Winner_ASCII_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string winner = string.Empty;
            int maxSum = 0;
            string input = Console.ReadLine();

            while (!input.Equals("STOP", StringComparison.CurrentCultureIgnoreCase))
            {
                int currentSum = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    currentSum += input[i];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    winner = input;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winner} - {maxSum}!");
        }
    }
}
