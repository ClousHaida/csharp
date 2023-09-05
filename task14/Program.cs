/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да

*/

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;

if (number % (number1*number2) == 0)
{
    Console.WriteLine($"число {number} кратно {number1} и {number2}");
}
else
{
    Console.WriteLine($"число {number} некратно");
}