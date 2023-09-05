/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int [] work = {1,2,3,4,5};
int [] holydays ={6,7};
Console.WriteLine("Введите число: ");
int Day = Convert.ToInt32(Console.ReadLine());

if(Day == work[0] || Day == work[1] || Day == work[2] || Day == work[3] || Day == work[4]) 
{
	Console.WriteLine("Это не выходной");
}
else if (Day == holydays[0] || Day == holydays [1])
{
    Console.WriteLine("Это выходной");
}
else if (Day != work[0] || Day != work[1] || Day != work[2] || Day != work[3] || Day != work[4] || Day != holydays[0] || Day !=holydays[1])
{
	Console.WriteLine("Такого дня не существует");
}
