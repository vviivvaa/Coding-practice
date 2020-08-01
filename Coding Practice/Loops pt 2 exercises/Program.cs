using System;

namespace Loops_pt_2_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            double evenSum = 0.0;
            double oddSum = 0.0;
            double oddMax = -1000000000.0;
            double evenMax = -1000000000.0;
            double oddMin = 1000000000.0;
            double evenMin = 1000000000.0;

            for (int i = 1; i <= iterations; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    if (currentNum > oddMax)
                    {
                        oddMax = currentNum;
                    }

                    if (currentNum < oddMin)
                    {
                        oddMin = currentNum;

                    }
                    oddSum += currentNum;
                }
                else
                {
                    if (currentNum > evenMax)
                    {
                        evenMax = currentNum;
                    }

                    if (currentNum < evenMin)
                    {
                        evenMin = currentNum;
                    }

                    evenSum += currentNum;
                }


            }

            if (evenMin == 1000000000.0 || evenMax == -1000000000.0)
            {
                if (oddMax == -1000000000.0 || oddMin == 1000000000.0)
                {

                    Console.WriteLine($"OddSum={oddSum:F2},\nOddMin=No,\nOddMax=No,\nEvenSum={evenSum:F2},\nEvenMin=No,\nEvenMax=No");

                }
                else
                {
                    Console.WriteLine($"OddSum={oddSum:F2},\nOddMin={oddMin:F2},\nOddMax={oddMin:F2},\nEvenSum={evenSum:F2},\nEvenMin=No,\nEvenMax=No");

                }

            }

            else
            {
                Console.WriteLine($"OddSum={oddSum:F2},\nOddMin={oddMin:F2},\nOddMax={oddMax:F2},\nEvenSum={evenSum:F2},\nEvenMin={evenMin:F2},\nEvenMax={evenMax:F2}");

            }


        }
    }
}


