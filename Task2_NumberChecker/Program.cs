using System;

namespace Task2_NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("=== ПРОГРАМА ПЕРЕВІРКИ ЧИСЕЛ ===\n");
            
            try
            {
                // Запит першого числа
                Console.Write("Введіть перше ціле число: ");
                if (!int.TryParse(Console.ReadLine(), out int firstNumber))
                {
                    Console.WriteLine("Помилка: Введіть коректне ціле число!");
                    return;
                }
                
                // Перевірка парності/непарності
                Console.WriteLine($"\n--- Аналіз числа {firstNumber} ---");
                
                if (IsEven(firstNumber))
                {
                    Console.WriteLine($"Число {firstNumber} є ПАРНИМ.");
                }
                else
                {
                    Console.WriteLine($"Число {firstNumber} є НЕПАРНИМ.");
                }
                
                // Перевірка подільності на 4
                if (firstNumber % 4 == 0)
                {
                    Console.WriteLine($"Число {firstNumber} ДІЛИТЬСЯ на 4.");
                }
                else
                {
                    Console.WriteLine($"Число {firstNumber} НЕ ДІЛИТЬСЯ на 4.");
                }
                
                // Запит другого числа
                Console.Write("\nВведіть друге ціле число: ");
                if (!int.TryParse(Console.ReadLine(), out int secondNumber))
                {
                    Console.WriteLine("Помилка: Введіть коректне ціле число!");
                    return;
                }
                
                // Перевірка подільності між числами
                Console.WriteLine($"\n--- Аналіз подільності між {firstNumber} та {secondNumber} ---");
                
                bool firstDividesSecond = false;
                bool secondDividesFirst = false;
                
                // Перевірка, чи перше ділиться на друге
                if (secondNumber != 0 && firstNumber % secondNumber == 0)
                {
                    firstDividesSecond = true;
                    Console.WriteLine($"Число {firstNumber} ДІЛИТЬСЯ на {secondNumber}.");
                    Console.WriteLine($"Результат ділення: {firstNumber} ÷ {secondNumber} = {firstNumber / secondNumber}");
                }
                
                // Перевірка, чи друге ділиться на перше
                if (firstNumber != 0 && secondNumber % firstNumber == 0)
                {
                    secondDividesFirst = true;
                    Console.WriteLine($"Число {secondNumber} ДІЛИТЬСЯ на {firstNumber}.");
                    Console.WriteLine($"Результат ділення: {secondNumber} ÷ {firstNumber} = {secondNumber / firstNumber}");
                }
                
                // Якщо жодне не ділиться на інше
                if (!firstDividesSecond && !secondDividesFirst)
                {
                    if (firstNumber == 0 && secondNumber == 0)
                    {
                        Console.WriteLine("Обидва числа дорівнюють нулю. Ділення неможливе.");
                    }
                    else if (firstNumber == 0)
                    {
                        Console.WriteLine($"Число {firstNumber} дорівнює нулю, тому ділення {secondNumber} на {firstNumber} неможливе.");
                        Console.WriteLine($"Але {firstNumber} ділиться на {secondNumber} (результат: 0).");
                    }
                    else if (secondNumber == 0)
                    {
                        Console.WriteLine($"Число {secondNumber} дорівнює нулю, тому ділення {firstNumber} на {secondNumber} неможливе.");
                        Console.WriteLine($"Але {secondNumber} ділиться на {firstNumber} (результат: 0).");
                    }
                    else
                    {
                        Console.WriteLine($"Жодне з чисел не ділиться нацело на інше:");
                        Console.WriteLine($"  {firstNumber} ÷ {secondNumber} = {(double)firstNumber / secondNumber:F2}");
                        Console.WriteLine($"  {secondNumber} ÷ {firstNumber} = {(double)secondNumber / firstNumber:F2}");
                    }
                }
                
                // Додаткова інформація про обидва числа
                Console.WriteLine($"\n--- Додаткова інформація ---");
                Console.WriteLine($"Перше число ({firstNumber}): {(IsEven(firstNumber) ? "парне" : "непарне")}");
                Console.WriteLine($"Друге число ({secondNumber}): {(IsEven(secondNumber) ? "парне" : "непарне")}");
                
                if (Math.Abs(firstNumber) == Math.Abs(secondNumber))
                {
                    Console.WriteLine("Числа є рівними за абсолютною величиною.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла непередбачена помилка: {ex.Message}");
            }
            
            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення програми...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Метод для перевірки, чи є число парним
        /// </summary>
        /// <param name="number">Число для перевірки</param>
        /// <returns>true, якщо число парне; false, якщо непарне</returns>
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}