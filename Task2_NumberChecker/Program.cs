namespace Task2_NumberChecker
{
    internal static class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("=== NUMBER CHECKER PROGRAM ===\n");
            
            try
            {
                var firstNumber = RequestInteger("Enter the first integer: ");
                
                Console.WriteLine($"\n--- Analysis of number {firstNumber} ---");
                
                var evenOddMessage = IsEven(firstNumber) ? "EVEN" : "ODD";
                Console.WriteLine($"Number {firstNumber} is {evenOddMessage}.");
                
                var divisibilityMessage = firstNumber % 4 == 0 ? "IS DIVISIBLE" : "is NOT DIVISIBLE";
                Console.WriteLine($"Number {firstNumber} {divisibilityMessage} by 4.");
                
                var secondNumber = RequestInteger("\nEnter the second integer: ");
                
                Console.WriteLine($"\n--- Divisibility analysis between {firstNumber} and {secondNumber} ---");
                
                var firstDividesSecond = false;
                var secondDividesFirst = false;
                
                if (secondNumber != 0 && firstNumber % secondNumber == 0)
                {
                    firstDividesSecond = true;
                    Console.WriteLine($"Number {firstNumber} IS DIVISIBLE by {secondNumber}.");
                    Console.WriteLine($"Division result: {firstNumber} ÷ {secondNumber} = {firstNumber / secondNumber}");
                }
                
                if (firstNumber != 0 && secondNumber % firstNumber == 0)
                {
                    secondDividesFirst = true;
                    Console.WriteLine($"Number {secondNumber} IS DIVISIBLE by {firstNumber}.");
                    Console.WriteLine($"Division result: {secondNumber} ÷ {firstNumber} = {secondNumber / firstNumber}");
                }
                
                // If neither divides by the other
                if (!firstDividesSecond && !secondDividesFirst)
                {
                    switch (firstNumber)
                    {
                        case 0 when secondNumber == 0:
                            Console.WriteLine("Both numbers equal zero. Division is impossible.");
                            break;
                        case 0:
                            Console.WriteLine($"Number {firstNumber} equals zero, so division of {secondNumber} by {firstNumber} is impossible.");
                            Console.WriteLine($"But {firstNumber} is divisible by {secondNumber} (result: 0).");
                            break;
                        default:
                        {
                            if (secondNumber == 0)
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

                            break;
                        }
                    }
                }
                
                // Additional information about both numbers
                Console.WriteLine($"\n--- Additional Information ---");
                Console.WriteLine($"First number ({firstNumber}): {(IsEven(firstNumber) ? "even" : "odd")}");
                Console.WriteLine($"Second number ({secondNumber}): {(IsEven(secondNumber) ? "even" : "odd")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            
            Console.WriteLine("\nPress any key to exit the program...");
            Console.ReadKey();
        }
        
        private static int RequestInteger(string prompt)
        {
            Console.Write(prompt);
            return !int.TryParse(Console.ReadLine(), out var number) ? throw new ArgumentException("Error: Enter a valid integer!") : number;
        }

        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}