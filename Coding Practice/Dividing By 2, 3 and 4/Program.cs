using System;

namespace Dividing_By_2__3_and_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
           

            for (int i = 0; i < n; i++)
            {
                int CurrentNum = int.Parse(Console.ReadLine());

                if (CurrentNum % 2 == 0)
                {
                    p1++;
                }

                if (CurrentNum % 3 == 0)
                {
                    p2++;
                }

                if (CurrentNum % 4 == 0)
                {
                    p3++;
                }

            }

            double p1Percent = p1 / n * 100;
            double p2Percent = p2 / n * 100;
            double p3Percent = p3 / n * 100;

            Console.WriteLine($"{p1Percent:F2}%\n{p2Percent:F2}%\n{p3Percent:F2}%");
        }
    }
}
