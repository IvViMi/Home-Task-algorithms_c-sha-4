/*
Задача 29 
Напишите программу, которая задаёт массив из 8 элементов, 
заполненный псевдослучайными числами и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/
Console.Clear();
Console.WriteLine("Заполнение 8-местного массива псевдослучайными целыми числами в интервале от 0 до 100");
int[] array = new int[8];
string RandomArrI8I(int[] array)
{
    string result = string.Empty;
    for (int num = 0; num < array.Length; num++)
    {
        array[num] = new Random().Next(0, 101);
    }
    for (int num = 0; num < array.Length; num++)
    {
        result += $"{array[num]}  ";
    }
    return result;
}
Console.WriteLine(RandomArrI8I(array));