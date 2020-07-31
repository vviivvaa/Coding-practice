using System;
using System.Net.Http.Headers;

namespace ForExcercisesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthDay = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double savedMoney = 0.0;
            int ownedToys = 0;

            for (int i = 1; i <= birthDay; i++)
            {
                if (i % 2 == 0)
                { 
                    
                    savedMoney += (i / 2) * 10;
                    savedMoney -= 1;
                }
                else
                {
                    ownedToys++;
                }
            }

            double moneyFromToys = ownedToys * toyPrice;
            savedMoney += moneyFromToys;

            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(savedMoney - washingMachinePrice):F2}");
            }
        }
    }
}
