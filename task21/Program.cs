/*
Напишите прошрамму, которая принимает на вход число () и выдает таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (number < 0) number = number * -1;
for (int i=1; i<number+1; i++)
{
    result =i*i*i;
    Console.WriteLine(result);
}