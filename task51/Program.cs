// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Console.Clear();

int[,] Get2DArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
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

int CountSumArray(int[,] array)
{
    int result = 0;
    int col = array.GetLength(0);
    int row = array.GetLength(1);
    int size = col;
    if (col > row) size = row;

    for (int i = 0; i < size; i++)
    {
        result += array[i, i];
    }
    return result;
}

int[,] Arr = Get2DArray(10, 5, 0, 10);
Print2DArray(Arr);
System.Console.WriteLine();
System.Console.WriteLine(CountSumArray(Arr));