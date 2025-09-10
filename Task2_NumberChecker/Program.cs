using System;

namespace Task2_NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("=== NUMBER CHECKER PROGRAM ===\n");
            
            try
            {
                Console.Write("Enter the first integer: ");
                if (!int.TryParse(Console.ReadLine(), out int firstNumber))
                {
                    Console.WriteLine("Error: Enter a valid integer!");
                    return;
                }
                
                Console.WriteLine($"\n--- Analysis of number {firstNumber} ---");
                
                if (IsEven(firstNumber))
                {
                    Console.WriteLine($"Number {firstNumber} is EVEN.");
                }
                else
                {
                    Console.WriteLine($"Number {firstNumber} is ODD.");
                }
                
                // Check divisibility by 4
                if (firstNumber % 4 == 0)
                {
                    Console.WriteLine($"Number {firstNumber} IS DIVISIBLE by 4.");
                }
                else
                {
                    Console.WriteLine($"Number {firstNumber} is NOT DIVISIBLE by 4.");
                }
                
                // Request second number
                Console.Write("\nEnter the second integer: ");
                if (!int.TryParse(Console.ReadLine(), out int secondNumber))
                {
                    Console.WriteLine("Error: Enter a valid integer!");
                    return;
                }
                
                // Check divisibility between numbers
                Console.WriteLine($"\n--- Divisibility analysis between {firstNumber} and {secondNumber} ---");
                
                bool firstDividesSecond = false;
                bool secondDividesFirst = false;
                
                // Check if the first number divides by the second
                if (secondNumber != 0 && firstNumber % secondNumber == 0)
                {
                    firstDividesSecond = true;
                    Console.WriteLine($"Number {firstNumber} IS DIVISIBLE by {secondNumber}.");
                    Console.WriteLine($"Division result: {firstNumber} ÷ {secondNumber} = {firstNumber / secondNumber}");
                }
                
                // Check if the second number divides by the first
                if (firstNumber != 0 && secondNumber % firstNumber == 0)
                {
                    secondDividesFirst = true;
                    Console.WriteLine($"Number {secondNumber} IS DIVISIBLE by {firstNumber}.");
                    Console.WriteLine($"Division result: {secondNumber} ÷ {firstNumber} = {secondNumber / firstNumber}");
                }
                
                // If neither divides by the other
                if (!firstDividesSecond && !secondDividesFirst)
                {
                    if (firstNumber == 0 && secondNumber == 0)
                    {
                        Console.WriteLine("Both numbers equal zero. Division is impossible.");
                    }
                    else if (firstNumber == 0)
                    {
                        Console.WriteLine($"Number {firstNumber} equals zero, so division of {secondNumber} by {firstNumber} is impossible.");
                        Console.WriteLine($"But {firstNumber} is divisible by {secondNumber} (result: 0).");
                    }
                    else if (secondNumber == 0)
                    {
                        Console.WriteLine($"Number {secondNumber} equals zero, so division of {firstNumber} by {secondNumber} is impossible.");
                        Console.WriteLine($"But {secondNumber} is divisible by {firstNumber} (result: 0).");
                    }
                    else
                    {
                        Console.WriteLine($"Neither number divides evenly by the other:");
                        Console.WriteLine($"  {firstNumber} ÷ {secondNumber} = {(double)firstNumber / secondNumber:F2}");
                        Console.WriteLine($"  {secondNumber} ÷ {firstNumber} = {(double)secondNumber / firstNumber:F2}");
                    }
                }
                
                // Additional information about both numbers
                Console.WriteLine($"\n--- Additional Information ---");
                Console.WriteLine($"First number ({firstNumber}): {(IsEven(firstNumber) ? "even" : "odd")}");
                Console.WriteLine($"Second number ({secondNumber}): {(IsEven(secondNumber) ? "even" : "odd")}");
                
                if (Math.Abs(firstNumber) == Math.Abs(secondNumber))
                {
                    Console.WriteLine("The numbers are equal in absolute value.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            
            Console.WriteLine("\nPress any key to exit the program...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Method to check if a number is even
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns>true if the number is even; false if odd</returns>
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}