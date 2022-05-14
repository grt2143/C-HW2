// Программа принимает на вход цифру обозначающую день недели и проверяет, является ли он выходным

Console.WriteLine("Введите число от 1 до 7:");
int dayNumber = int.Parse(Console.ReadLine());
if (dayNumber == 6 || dayNumber == 7)
    Console.WriteLine("да");
else if (dayNumber < 1 || dayNumber > 7)
    Console.WriteLine("Введенное число не соответствует условию");
else
    Console.WriteLine("нет");
