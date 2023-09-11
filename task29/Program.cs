/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


// System.Console.WriteLine("Введите число: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int [] GetRandom(int arrayLength)
{
    int[] array=new int[arrayLength];
    for(int i=0; i<array.Length;i++)
    {
        array[i]=new Random().Next(0,arrayLength);
    }
    return array;
}

int[] userArray = GetRandom(arrayLength);

void PrintArray(int[] arrayToPrint)
{
    System.Console.Write("[");
    for (int i=0; i<arrayToPrint.Length;i++)
    {
        System.Console.Write($"{arrayToPrint[i]} ");
    }
    System.Console.Write("]");
}

PrintArray(userArray);
// System.Console.WriteLine("Введите число: ");