Console.WriteLine("Введите число  ");
int numN = Convert.ToInt32(Console.ReadLine());
int i = 1, k = 1; 
while (true)
{ 
    if (i % 2 == 0)
    { Console.Write(i + " ");
    k++;
    }
    if (i == numN)
    { break; }
     i++;}



Console.WriteLine("Введите число a");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{ 
    Console.WriteLine($"Max = {num1} Min = {num2}");
    }
else
{ 
    Console.WriteLine($"Max = {num2} Min = {num1}");
    }

    

Console.WriteLine("Введите число a: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int numC = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    if (numA > numC)
    {
        Console.WriteLine("max: " + numA);
    }
    else
    {
        Console.WriteLine("max: " + numC);
    }
}

else if (numB > numC)
{
    Console.WriteLine("max: " + numB);
}
else
{
    Console.WriteLine("max: " + numC);



Console.WriteLine("Введите число: " );
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
    { 
        Console.Write( "Четное");
    }
    else
    {
        Console.Write("Нечетное");
    }
 