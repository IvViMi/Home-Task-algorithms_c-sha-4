/*
Задача 27 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
Console.WriteLine("Определение суммы цифр целого числа");
Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine());
int z = n;
int i = 0;
int sum = 0;
for (i = 0; z > 0;)
{
    sum += z % 10;
    z = z / 10;
}
Console.WriteLine($"Сумма цифр числа '{n}' равна '{+ sum}'");
