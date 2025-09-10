using System;

namespace Task1_AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("=== ПРОГРАМА РОЗРАХУНКУ ВІКУ ДО 100 РОКІВ ===\n");
            
            try
            {
                // Запит імені користувача
                Console.Write("Введіть ваше ім'я: ");
                string name = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Помилка: Ім'я не може бути порожнім!");
                    return;
                }
                
                // Запит віку користувача
                Console.Write("Введіть ваш поточний вік: ");
                if (!int.TryParse(Console.ReadLine(), out int currentAge) || currentAge < 0)
                {
                    Console.WriteLine("Помилка: Введіть коректний вік (ціле позитивне число)!");
                    return;
                }
                
                if (currentAge >= 100)
                {
                    Console.WriteLine($"Вітаємо, {name}! Вам вже виповнилося 100 років або більше!");
                }
                else
                {
                    // Розрахунок року, коли виповниться 100
                    int currentYear = DateTime.Now.Year;
                    int yearWhen100 = currentYear + (100 - currentAge);
                    
                    string message = $"Привіт, {name}! Вам виповниться 100 років у {yearWhen100} році.";
                    Console.WriteLine($"\n{message}");
                    
                    // Запит кількості повторень
                    Console.Write("\nВведіть ціле позитивне число для повторення повідомлення: ");
                    if (!int.TryParse(Console.ReadLine(), out int repeatCount) || repeatCount <= 0)
                    {
                        Console.WriteLine("Помилка: Введіть коректне ціле позитивне число!");
                        return;
                    }
                    
                    Console.WriteLine($"\nПовідомлення буде виведено {repeatCount} раз(ів):\n");
                    Console.WriteLine(new string('=', 50));
                    
                    // Виведення повідомлення зазначену кількість разів
                    for (int i = 1; i <= repeatCount; i++)
                    {
                        Console.WriteLine($"{i}. {message}");
                    }
                    
                    Console.WriteLine(new string('=', 50));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла непередбачена помилка: {ex.Message}");
            }
            
            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення програми...");
            Console.ReadKey();
        }
    }
}