/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int numberTwo = number / 10;
Console.WriteLine(numberTwo);

int result = numberTwo%10;
Console.WriteLine(result);