/*
Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
*/

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int count(int number)
{
    int result=0;
    while (number > 0)
    {
        result++;
        number=number/10;
    }
return result;
}

Console.WriteLine(count(userNumber));