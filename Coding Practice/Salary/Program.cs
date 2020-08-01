using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < tabs; i++)
            {
                string currentTab = Console.ReadLine();

                if (currentTab == "Facebook")
                {
                    salary -= 150;
                }
                else if (currentTab == "Instagram")
                {
                    salary -= 100;
                }
                else if (currentTab == "Reddit")
                {
                    salary -= 50;
                }
               
                if (salary <= 0)
                {

                    Console.WriteLine("You have lost your salary.");
                    break;

                }
            }

            if (salary > 0)
            {

                Console.WriteLine(salary);
            }
        }
    }
}
