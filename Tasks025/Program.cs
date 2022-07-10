/*
Задача 25 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();
Console.WriteLine("Возведение целого числа А в натуральныю степень целого чиса В");
Console.Write("Введите целое число A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int c = 1;
for (int i = 1; i <= b; i++)
{
    c*=a;
}
Console.WriteLine($"Результат возведения числа '{a}' в степень '{b}' соответсвует '{c}'" );