using System;

namespace DecisionApp
{
    public class NumberReverser
    {
        public static void ReverseNumber()
        {
            Console.WriteLine("Choose a method for reversing numbers:");
            Console.WriteLine("1. Simple reversing");
            Console.WriteLine("2. Complex reversing");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SimpleReversing();
                    break;
                case "2":
                    ComplexReversing();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private static void SimpleReversing()
        {
            Console.WriteLine("Enter a number to reverse:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int reversed = 0;
                while (number > 0)
                {
                    reversed = reversed * 10 + number % 10;
                    number /= 10;
                }
                Console.WriteLine($"Reversed number: {reversed}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        private static void ComplexReversing()
        {
            Console.WriteLine("Enter a number to reverse (complex logic):");
            string input = Console.ReadLine();
            char[] reversed = input.ToCharArray();
            Array.Reverse(reversed);
            Console.WriteLine($"Reversed number: {new string(reversed)}");
        }
    }
}
