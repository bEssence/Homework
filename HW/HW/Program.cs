Console.WriteLine("Как вас зовут?\n");

string? name = Console.ReadLine();

Console.WriteLine($"\nЗдравствуйте {name}, приветствую вас в игре 'Угадай число'.\n" +
                  $"Ваша цель - угадать число в промежутке от 0 до 99, удачи!");

Random random = new Random();
int hiddenNumber = random.Next(0, 100);
int userNumber = -1;
int amountOfAttempts = 0;
bool userWon = false;

while (!userWon)
{
    bool isInt = false;
    Console.WriteLine("\nВведите ваше число.");

    isInt = int.TryParse(Console.ReadLine(), out userNumber);
    if (!isInt)
    {
        Console.WriteLine("Вы ввели не число, либо число с плавающей точкой.\n" +
                          "Попробуйте снова.");
        continue;
    }
    else if (userNumber > 100 || userNumber <= 0)
    {
        Console.WriteLine("Число выходит за границы промежутка, вы будете арестованы!");
        continue;
    }

    amountOfAttempts += 1;

    if (userNumber == hiddenNumber)
    {
        Console.WriteLine("\nПоздравляем, вы угадали число!" +
                         $"\nКоличество попыток - { amountOfAttempts}");
        userWon = true;
    }
    else if (userNumber < hiddenNumber)
    {
        Console.WriteLine("\nВаше число меньше загаданного.");
    }
    else
    {
        Console.WriteLine("\nВаше число больше загаданного.");
    }
}
Console.ReadLine();
