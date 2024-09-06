using System;
using System.Collections.Generic;

namespace ScientificCalculator
{
    class Program
    {
        static List<string> history = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Scientific Calculator");
                Console.WriteLine("1. Arithmetic Operations");
                Console.WriteLine("2. Trigonometric Operations");
                Console.WriteLine("3. Logarithmic Operations");
                Console.WriteLine("4. View History");
                Console.WriteLine("5. Clear History");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ArithmeticOperations();
                        break;
                    case 2:
                        TrigonometricOperations();
                        break;
                    case 3:
                        LogarithmicOperations();
                        break;
                    case 4:
                        ViewHistory();
                        break;
                    case 5:
                        ClearHistory();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }

        static void ArithmeticOperations()
        {
            Console.WriteLine("Arithmetic Operations");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Square Root");
            Console.WriteLine("6. Back");

            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    SquareRoot();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }

        static void TrigonometricOperations()
        {
            Console.WriteLine("Trigonometric Operations");
            Console.WriteLine("1. Sine");
            Console.WriteLine("2. Cosine");
            Console.WriteLine("3. Tangent");
            Console.WriteLine("4. Back");

            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Sine();
                    break;
                case 2:
                    Cosine();
                    break;
                case 3:
                    Tangent();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }

        static void LogarithmicOperations()
        {
            Console.WriteLine("Logarithmic Operations");
            Console.WriteLine("1. Natural Logarithm");
            Console.WriteLine("2. Back");

            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    NaturalLogarithm();
                    break;
                case 2:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }

        static void Addition()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 + num2;
            Console.WriteLine($"Result: {result}");
            history.Add($"{num1} + {num2} = {result}");
        }

        static void Subtraction()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 - num2;
            Console.WriteLine($"Result: {result}");
            history.Add($"{num1} - {num2} = {result}");
        }

        static void Multiplication()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 * num2;
            Console.WriteLine($"Result: {result}");
            history.Add($"{num1} * {num2} = {result}");
        }

        static void Division()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }

            double result = num1 / num2;
            Console.WriteLine($"Result: {result}");
            history.Add($"{num1} / {num2} = {result}");
        }

        static void SquareRoot()
        {
            Console.Write("Enter the number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Error: Cannot calculate the square root of a negative number.");
                return;
            }

            double result = Math.Sqrt(num);
            Console.WriteLine($"Result: {result}");
            history.Add($"sqrt({num}) = {result}");
        }

        static void Sine()
        {
            Console.Write("Enter the angle in degrees: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            double radians = angle * (Math.PI / 180);
            double result = Math.Sin(radians);
            Console.WriteLine($"Result: {result}");
            history.Add($"sin({angle}) = {result}");
        }

        static void Cosine()
        {
            Console.Write("Enter the angle in degrees: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            double radians = angle * (Math.PI / 180);
            double result = Math.Cos(radians);
            Console.WriteLine($"Result: {result}");
            history.Add($"cos({angle}) = {result}");
        }

        static void Tangent()
        {
            Console.Write("Enter the angle in degrees: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            double radians = angle * (Math.PI / 180);
            double result = Math.Tan(radians);
            Console.WriteLine($"Result: {result}");
            history.Add($"tan({angle}) = {result}");
        }

        static void NaturalLogarithm()
        {
            Console.Write("Enter the number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Error: Logarithm is not defined for zero or negative numbers.");
                return;
            }

            double result = Math.Log(num);
            Console.WriteLine($"Result: {result}");
            history.Add($"ln({num}) = {result}");
        }

        static void ViewHistory()
        {
            Console.WriteLine("Calculation History:");
            if (history.Count == 0)
            {
                Console.WriteLine("No history available.");
            }
            else
            {
                foreach (string record in history)
                {
                    Console.WriteLine(record);
                }
            }
        }

        static void ClearHistory()
        {
            history.Clear();
            Console.WriteLine("History cleared.");
        }
    }
}
