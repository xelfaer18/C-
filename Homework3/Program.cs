/*Задача 21 (branch task_2)
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GL (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dl = Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z2-z1) * (z2-z1));
    return dl;
}

Console.WriteLine("Input coordinate X1");
double x1 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Y1");
double y1 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Z1");
double z1 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate X2");
double x2 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Y2");
double y2 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Z2");
double z2 =Convert.ToDouble(Console.ReadLine());

double result = GL(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Длинна отрезка {result}");

/*Домашняя работа: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Kub (int N)
{
     for (int i = 1; i <= N; i++)
    {
         Console.WriteLine($"{i} -> {i*i*i}");
    }
}
Console.Write ("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
Kub (N);*/

/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

*/

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;
Pol(number);

void Pol (int number)
{
     if(len == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
            {
                 Console.WriteLine($"{number} - Палиндром");
            }
        else
         {
         Console.WriteLine($"{number} - НЕ палиндром");
        }
    }
    else
    {
        Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
    }
}

