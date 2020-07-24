using System;
using System.Diagnostics.CodeAnalysis;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            int receivedPoorGrades = 0;
            double sum = 0;
            int numberOfTasks = 0;


            string lastAssignmentName = string.Empty;

            while (receivedPoorGrades < poorGrades)
            {
                string currentAssignmentName = Console.ReadLine();

                if (currentAssignmentName == "Enough")
                {
                    Console.WriteLine($"Average score: {(sum / numberOfTasks):F2}");
                    Console.WriteLine($"Number of problems: {numberOfTasks}");
                    Console.WriteLine($"Last problem: {lastAssignmentName}");
                    break;
                }

                int currentResult = int.Parse(Console.ReadLine());

                numberOfTasks++;
                sum += currentResult;

                if (currentResult <= 4)
                {
                    receivedPoorGrades++;
                    if (receivedPoorGrades == poorGrades)
                    {
                        Console.WriteLine($"You need a break, {receivedPoorGrades} poor grades.");
                        break;
                    }
                }
                lastAssignmentName = currentAssignmentName;
            }

        }

    }
}
