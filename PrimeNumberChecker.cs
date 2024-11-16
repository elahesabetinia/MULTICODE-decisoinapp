using System;

namespace DecisionApp
{
    public class PrimeNumberChecker
    {
        public static void CheckPrimes()
        {
            Console.WriteLine("Choose a method for prime number calculation:");
            Console.WriteLine("1. Prime numbers up to 1000");
            Console.WriteLine("2. Prime number check above 1000");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PrintPrimesUpTo1000();
                    break;
                case "2":
                    CheckPrimeAbove1000();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private static void PrintPrimesUpTo1000()
        {
            Console.WriteLine("Prime numbers up to 1000:");
            for (int i = 2; i <= 1000; i++)
            {
                if (IsPrime(i))
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        private static void CheckPrimeAbove1000()
        {
            Console.WriteLine("Enter a number greater than 1000:");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 1000)
            {
                Console.WriteLine(IsPrime(number)
                    ? $"{number} is a prime number."
                    : $"{number} is not a prime number.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
