namespace Task1_AgeCalculator
{
    internal class Program
    {
        private string _name = string.Empty;
        private int _age;
        
        private string Name 
        { 
            get => _name; 
            set => _name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Name cannot be empty");
        }
        
        private int Age 
        { 
            get => _age; 
            set => _age = value >= 0 ? value : throw new ArgumentException("Age must be non-negative");
        }
        
        private static void Main()
        {
            var program = new Program();
            program.Run();
        }
        
        private void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("=== AGE CALCULATION PROGRAM TO 100 YEARS ===\n");
            
            try
            {
                CollectUserInfo();
                DisplayAgeCalculation();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            
            Console.WriteLine("\nPress any key to exit the program...");
            Console.ReadKey();
        }
        
        private void CollectUserInfo()
        {
            Name = ScanUserName();
            Age = ScanUserAge();
        }
        
        private void DisplayAgeCalculation()
        {
            if (Age >= 100)
            {
                Console.WriteLine($"Congratulations, {Name}! You are already 100 years old or more!");
            }
            else
            {
                var currentYear = DateTime.Now.Year;
                var yearWhen100 = currentYear + (100 - Age);
                
                var message = $"Hello, {Name}! You will turn 100 years old in {yearWhen100}.";
                Console.WriteLine($"\n{message}");
                
                DisplayRepeatedMessage(message);
            }
        }
        
        private static void DisplayRepeatedMessage(string message)
        {
            Console.Write("\nEnter a positive integer to repeat the message: ");
            if (!int.TryParse(Console.ReadLine(), out int repeatCount) || repeatCount <= 0)
            {
                Console.WriteLine("Error: Enter a valid positive integer!");
                return;
            }
            
            Console.WriteLine($"\nMessage will be displayed {repeatCount} time(s):\n");
            Console.WriteLine(new string('=', 50));
            
            for (int i = 1; i <= repeatCount; i++)
            {
                Console.WriteLine($"{i}. {message}");
            }
            
            Console.WriteLine(new string('=', 50));
        }

        private static string ScanUserName()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(name))
            {
                return name;
            }
            
            Console.WriteLine("Error: Name cannot be empty!");
            return string.Empty;
        }

        private static int ScanUserAge()
        {
            Console.Write("Enter your current age: ");
            if (!int.TryParse(Console.ReadLine(), out int userAge) || userAge < 0)
            {
                throw new ArgumentException("Invalid age entered");
            }
            
            return userAge;
        }
    }
}