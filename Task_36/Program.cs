// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] NewArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
} 

int OddNumbersSum (int[] array)
{
    int numbersSum = 0;
    for (int i = 1; i < array.Length; i +=2)
    {
        numbersSum += array[i];
    }
    
    return numbersSum;
}

int[] array = new int[10];
NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Сумма элементов на нечётных позициях равна " + OddNumbersSum(array));