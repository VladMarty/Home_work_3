// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
int len = num.Length;
if (len == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - Полиндром!");
    }
    else
    {
        Console.WriteLine($"{num} - Не полиндром!");
    }
}
else
{
    Console.WriteLine($"Ошибка: {num} - не явлеяется пятизначным!");
}