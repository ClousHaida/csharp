/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

int x1 = ReadInt("Введите x точки A: ");
int y1 = ReadInt("Введите y точки A: ");
int z1 = ReadInt("Введите z точки A: ");
int x2 = ReadInt("Введите x точки B: ");
int y2 = ReadInt("Введите y точки B: ");
int z2 = ReadInt("Введите z точки B: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние = " + length);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}