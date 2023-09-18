// Напишите программу, которая будет преобразовывать десятичное число в двоичное. 


Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

string Difusion(int a)
{
    string result = String.Empty;
    int temp = 0;
    for (int i = a; i > 0; i /= 2)
    {
        temp = i % 2;
        result = temp + result;
    }

    return result;
}

string b = Difusion(a);
Console.WriteLine(b);