
/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Length = number.ToString().Length;

if (Length >= 3)
{
    while (number> 999)
    {
        number=number/10;
    }
    int result = number % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}

