using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1Numbers = 0;
            double p3Numbers = 0;
            double p2Numbers = 0;
            double p4Numbers = 0;
            double p5Numbers = 0;
          

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < 200)
                {
                    p1Numbers++;
                }
                else if (currentNum >= 200 && currentNum <= 399)
                {
                    p2Numbers++;
                }
                else if (currentNum >= 400 && currentNum <= 599)
                {
                    p3Numbers++;
                }
                else if (currentNum >= 600 && currentNum <= 799)
                {
                    p4Numbers++;
                }
                else if (currentNum >= 800)
                {
                    p5Numbers++;
                }
            }

            double p1Percent = p1Numbers / n * 100;
            double p2Percent = p2Numbers / n * 100;
            double p3Percent = p3Numbers / n * 100;
            double p4Percent = p4Numbers / n * 100;
            double p5Percent = p5Numbers / n * 100;

            Console.WriteLine($"{p1Percent:F2}%\n{p2Percent:F2}%\n{p3Percent:F2}%\n{p4Percent:F2}%\n{p5Percent:F2}%");

        }
    }
}
