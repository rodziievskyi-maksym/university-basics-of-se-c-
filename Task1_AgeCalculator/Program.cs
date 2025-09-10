using System;

namespace Task1_AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("=== AGE CALCULATION PROGRAM TO 100 YEARS ===\n");
            
            try
            {
                // Request user's name
                Console.Write("Enter your name: ");
                string? name = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Error: Name cannot be empty!");
                    return;
                }
                
                // Request user's age
                Console.Write("Enter your current age: ");
                if (!int.TryParse(Console.ReadLine(), out int currentAge) || currentAge < 0)
                {
                    Console.WriteLine("Error: Enter a valid age (positive integer)!");
                    return;
                }
                
                if (currentAge >= 100)
                {
                    Console.WriteLine($"Congratulations, {name}! You are already 100 years old or more!");
                }
                else
                {
                    // Calculate the year when user turns 100
                    int currentYear = DateTime.Now.Year;
                    int yearWhen100 = currentYear + (100 - currentAge);
                    
                    string message = $"Hello, {name}! You will turn 100 years old in {yearWhen100}.";
                    Console.WriteLine($"\n{message}");
                    
                    // Request number of repetitions
                    Console.Write("\nEnter a positive integer to repeat the message: ");
                    if (!int.TryParse(Console.ReadLine(), out int repeatCount) || repeatCount <= 0)
                    {
                        Console.WriteLine("Error: Enter a valid positive integer!");
                        return;
                    }
                    
                    Console.WriteLine($"\nMessage will be displayed {repeatCount} time(s):\n");
                    Console.WriteLine(new string('=', 50));
                    
                    // Display message the specified number of times
                    for (int i = 1; i <= repeatCount; i++)
                    {
                        Console.WriteLine($"{i}. {message}");
                    }
                    
                    Console.WriteLine(new string('=', 50));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            
            Console.WriteLine("\nPress any key to exit the program...");
            Console.ReadKey();
        }
    }
}