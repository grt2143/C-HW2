// Программа принимет на вход трёхзначное число и показывает 2ю цифру этого числа

Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine());
int secondDigit = (number / 10) % 10;
Console.WriteLine($"Вторая цифра числа: {secondDigit}");