/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
*/

Console.Clear();

int[] userArray = FillArray(10, 0, 100);
int[] FillArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

void PrintResult(int[] arrayRes)
{
    int sum = 0;
    for(int i = 1; i < arrayRes.Length; i += 2)
    {
        sum += arrayRes[i];
    }
    Console.WriteLine($"сумма эллементов: {sum}");
}

PrintArray(userArray);
PrintResult(userArray);