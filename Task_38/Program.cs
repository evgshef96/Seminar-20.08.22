//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

Console.Clear();

int[] NewArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

int MaxMinSum(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        max = array[i];
        if(array[i] < min)
        min = array[i];
    }

    int sum = max + min;
    return sum;
}

int[] array = new int[10];
NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Сумма максимального и минимального элементов массива равна " + MaxMinSum(array));


