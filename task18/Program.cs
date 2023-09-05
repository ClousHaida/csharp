/*
Напишите программу, которая по заданному номеру четверти показывает диапозон возможных точек в этой четверти.
*/

Console.WriteLine("Введите № четверти:");
int number0 = Convert.ToInt32(Console.ReadLine());

if (number0 == 1)
{
    Console.WriteLine("Все X > 0, все Y > 0");
}
else if(number0 ==2)
{
    Console.WriteLine("Все X < 0, все Y > 0");
}
else if(number0 ==3)
{
    Console.WriteLine("Все X < 0, все Y < 0");
}
else if(number0 ==4)
{
    Console.WriteLine("Все X > 0, все Y < 0");
}
else
{
    Console.WriteLine("Нет такой четверти");
}