/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
*/

Console.Clear();

int[,] GetRandom2DArray(int row, int col, int deviation)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] DoubleEven2DArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (i % 2 == 0 && j % 2 == 0) result[i, j] = array[i, j] * array[i, j];
            else result[i, j] = array[i, j];
        }
    }
    return result;
}

int[,] Array = GetRandom2DArray(5, 5, 10);
Print2DArray(Array);
int[,] newArray = DoubleEven2DArray(Array);
Print2DArray(newArray);