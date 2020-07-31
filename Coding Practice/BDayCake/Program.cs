using System;
using System.Collections.Generic;
using System.Linq;

namespace BDayCake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeHeight = int.Parse(Console.ReadLine());

            int cakeSize = cakeHeight * cakeWidth;

            while (true)
            {
                string pieces = Console.ReadLine();

                if (pieces.Equals("stop", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"{cakeSize} pieces are left.");
                    break;
                }

                cakeSize -= int.Parse(pieces);

                if (cakeSize < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
                    break;
                }
            }

        }
    }
}
