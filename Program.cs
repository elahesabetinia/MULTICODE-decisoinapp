using System;

namespace DecisionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Prime Number Calculation");
            Console.WriteLine("2. Number Reversing");
            Console.WriteLine("3. Decision Tree Drawing");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    PrimeNumberChecker.CheckPrimes();
                    break;
                case "2":
                    NumberReverser.ReverseNumber();
                    break;
                case "3":
                    DecisionTreeDrawer.DrawDecisionTree();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
