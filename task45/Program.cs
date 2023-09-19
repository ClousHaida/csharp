/*
Напишите программу, которая ябудет создавать копию заданного одномерного массива с помощью поэлементного копирования.
*/
using System.Collections;
double[] array = { 1, 2, 3, 4, 5 };

double[] CopyArray(double[] array)
{
    double[] arrayL = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayL[i] = array[i];
    }
    return arrayL;
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

double[] userArray = CopyArray(array);

PrintArray(userArray);