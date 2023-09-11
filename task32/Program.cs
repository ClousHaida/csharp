/*
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

/*
int min = new Random().Next(1, 10);
int[] array = FillArray(new Random().Next(1, 10), min, min + new Random().Next(1, 20));
Console.WriteLine("[" + string.Join(", ", array) + "]");

int[] FillArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}*/

Console.Clear();

int[] GetRandom(int arrayLength, int start, int end)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

System.Console.WriteLine("Введите число: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandom(arrayL, min, max);
PrintArray(userArray);

int[] ChangeSignArray(int[] array)
{
    for (int i= 0; i < array.Length; i++)
    {
    array[i] *=  -1;
}
return array;
}

System.Console.WriteLine();
PrintArray(ChangeSignArray(userArray));
// GetSum(userArray);