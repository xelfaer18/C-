Домашнее задание.Задача 25: 

void Stepen(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
        {
            result = result * a;
        }
    Console.WriteLine(result);
}

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
Stepen(numberA, numberB);

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}



/*
Задача 27: (branch task_2)
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12




int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);

*/