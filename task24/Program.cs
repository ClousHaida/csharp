/*
Напишите программу, которая на вход принимает число (А) и выдает сумму чисел от 1 до А.
*/

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());


int SumOfNumber(int number)
{
    int sum=0;
    for (int i=1; i<=userNumber; i++)
{
    sum+=i;
}
return sum;
}

Console.WriteLine($"сумма цифр в числе {userNumber} равна {SumOfNumber(userNumber)}");
