Console.WriteLine("Как вас зовут?");

Console.WriteLine();

string? name = Console.ReadLine();

Console.WriteLine();

Console.WriteLine($"Здравствуйте {name}, приветствую вас в игре 'Угадай число'.\n" +
                  $"Ваша цель - угадать число в промежутке от 0 до 99, удачи!");

Random random = new Random();
int hiddenNumber = random.Next(0,100);
int userNumber = -1;
int amountOfAttempts = 0;
bool userWon = false;

while (!userWon)
{
    bool isInt = false;
    Console.WriteLine();
    Console.WriteLine("Введите ваше число.");

    isInt = int.TryParse(Console.ReadLine(), out userNumber);
    if (!isInt)
    {
        Console.WriteLine("\nВы ввели не число, либо число с плавающей точкой.\n" +
                          "Попробуйте снова.");
        continue;
    }
    else if(userNumber>100 || userNumber <= 0) 
    {
        Console.WriteLine("Число выходит за гранцы промежутка, вы будете арестованы!");
        continue;
    }
    amountOfAttempts += 1;

    Console.WriteLine();

    if (userNumber == hiddenNumber)
    {
        Console.WriteLine("Поздравляем, вы угадали число!");
        Console.WriteLine($"Количество попыток - {amountOfAttempts}");
        userWon = true;
    }

    else if (userNumber < hiddenNumber)
    {
        Console.WriteLine("Ваше число меньше загаданного.");
    }

    else
    {
        Console.WriteLine("Ваше число больше загаданного.");
    }

    Console.WriteLine();
}
Console.ReadLine();