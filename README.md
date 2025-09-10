# university-basics-of-se-c-

Крок 2: Створення Solution та проектів
У Terminal в Rider (або в папці репи) виконайте:
bash# Створення solution файлу
dotnet new sln --name SE_Labs

# Створення першого проекту
dotnet new console --name Task1_AgeCalculator

# Створення другого проекту
dotnet new console --name Task2_NumberChecker

# Додавання проектів до solution
dotnet sln add Task1_AgeCalculator/Task1_AgeCalculator.csproj
dotnet sln add Task2_NumberChecker/Task2_NumberChecker.csproj


# Тестування першого проекту
cd Task1_AgeCalculator
dotnet run

# Повернення в корінь
cd ..

# Тестування другого проекту
cd Task2_NumberChecker
dotnet run