Домашняя работа: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -&gt; 5
782 -&gt; 8
918 -&gt; 1
int CenNum (int num)
{
    int dec = num /10;
    int res = dec % 10;
    return res;
}
Console.Write(&quot;Введите трёхзначное число:  &quot;);
int number = Convert.ToInt32(Console.ReadLine());
int newnum = CenNum(number);
Console.WriteLine($&quot;{newnum}&quot;);*/
Домашняя работа: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -&gt; 5
78 -&gt; третьей цифры нет
32679 -&gt; 6

int Tretiinum (int Array, int size)
{
int result = 0;
    if (size &lt; 3)
    {
        Console.Write($&quot;Третьей цифры нет, поэтому &quot;);
    }
    else
    {
        int c = 1;
        for (int i = size; i &gt; 3; i--)
        {
            c = c * 10;
        }
        result = (Array / c) % 10;
    }
return result;
}
int ReadInt(string message)
{
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadInt(&quot;Введите число: &quot;);
int count = number.ToString().Length;
Console.Write(Tretiinum(number, count));

Домашняя работа: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -&gt; да
7 -&gt; да
1 -&gt; нет

void weekend (int day)
{
    if(day &gt;= 1 &amp;&amp; day &lt;= 5)
    {
        Console.WriteLine(&quot;Рабочий&quot;);
        return;
    }
    Console.WriteLine(&quot;Выходной&quot;);
}
 
Console.Write(&quot;Введите число дня недели:  &quot;);
int number = Convert.ToInt32(Console.ReadLine());