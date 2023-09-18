/*
Напишите программу, которая перевернёт одномерный
массив (последний элемент будет на первом месте, а первый - на
последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

Console.Clear();

int[] userArray = FillArray(6, 0, 11);

int[] FillArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
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

int[] TurnArray(int[] arrayToTurn)
{
    int temp = 0;
    for (int i = 0; i < arrayToTurn.Length / 2; i++)
    {
        temp = arrayToTurn[i];
        arrayToTurn[i] = arrayToTurn[arrayToTurn.Length - 1 - i];
        arrayToTurn[arrayToTurn.Length - 1 - i] = temp;
    }
    return arrayToTurn;
}

Console.ForegroundColor = ConsoleColor.Blue;
PrintArray(userArray);
int[] turnArray = TurnArray(userArray);
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(turnArray);