using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int spendCounter = 0;

            while (ownedMoney < neededMoney)
            {
                string command = Console.ReadLine();
                double currentAmount = double.Parse(Console.ReadLine());

                days++;

                if (command == "save")
                {
                    spendCounter = 0;
                    ownedMoney += currentAmount;
                }
                else if (command == "spend")
                {
                    spendCounter++;
                    ownedMoney -= currentAmount;

                    if (ownedMoney < 0.0)
                    {
                        ownedMoney = 0;
                    }
                    
                    if (spendCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                }

                if (ownedMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                }

            }

        }
    }
}
