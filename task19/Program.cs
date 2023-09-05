/*
Напишите программу, которая принимает на вход 5-ти значное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine("Напишите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int Number = userNumber;
int numberTurn = 0;

if (userNumber< 0) userNumber = userNumber* -1;

if(userNumber>9999 && userNumber<100000)
{
    for(int i=userNumber; i>0;i/=10)
    {
        numberTurn=i%10+numberTurn*10;
    }
    if (userNumber== numberTurn) Console.WriteLine("является");
    else Console.WriteLine("не является");
}
else Console.WriteLine("ошибка");

/* if(userNumber>9999 && userNumber<100000)
{
    if(userNumber%10 == userNumber / 10000 && userNumber / 10 %10 == userNumber/1000 %10) Console.WriteLine("является");
    else Console.WriteLine("не является");
}
    else if (userNumber<-9999 && userNumber>-100000)
    {
         if(userNumber%10 == userNumber / 10000 && userNumber / 10 %10 == userNumber/1000 %10) Console.WriteLine("является");
         else Console.WriteLine("не является");
    }
else Console.WriteLine("ошибка");
*/