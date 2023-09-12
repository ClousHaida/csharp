/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/

Console.Clear();

double[] userArray = FillArray(10, 0, 100);
double[] FillArray(int length, double minValue, double maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) - minValue;
    }
    return array;
}

void PrintArray(double[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

/*void PrintResult(int[] arrayRes)
{
    int res = 0;
    for (int i = 1; i < arrayRes.Length; i++)
    {
        res = maxValue - minValue;
    }
    
}
*/
void PrintResult(double[] arrayforDiff)
{
    double max = arrayforDiff[0];
    double min = arrayforDiff[0];

    for (int i = 1; i < arrayforDiff.Length; i++)
    {
        if (max < arrayforDiff[i]) max = arrayforDiff[i];
        else if (min > arrayforDiff[i]) min = arrayforDiff[i];
    }
    System.Console.WriteLine(Math.Round(max - min, 2));
}

PrintArray(userArray); 

System.Console.WriteLine($"Разница максимального и минимального элементов:");
PrintResult(userArray);