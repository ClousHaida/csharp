/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

System.Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int Exp(int numberA, int numberB)
{
    int result=1;
    for(int i=1;i<=numberB; i++)
    {
        result=result*numberA;
    }
   // int result = Math.Pow(numberA, numberB);
    return result;
}
int ExpRes= Exp(numberA, numberB);
Console.WriteLine("Вывод: " + ExpRes);