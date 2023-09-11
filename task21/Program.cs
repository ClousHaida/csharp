/*
Напишите прошрамму, которая принимает на вход число () и выдает таблицу квадратов чисел от 1 до N.
*/

Console.WriteLine("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (number < 0) 
{
    number = number * (-1);
}
for (int i=1; i<=number; i++)
{
    result = i*i;
    Console.WriteLine(result);
}