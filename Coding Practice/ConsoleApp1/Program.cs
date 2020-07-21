using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string neededBook = Console.ReadLine();
            int libraryCapacity = int.Parse(Console.ReadLine());
            int iteration = 0;

            while (libraryCapacity != 0)
            {
                string currentBook = Console.ReadLine();

                if (currentBook == neededBook)
                {
                    Console.WriteLine($"You checked {iteration} books and found it.");
                    break;
                }
                iteration++;
                libraryCapacity--;
            }
            if (libraryCapacity == 0)
            {

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {iteration} books.");
            }

         
        }
    }
}
