//Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();
Console.Write("Введи M: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи N: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();

PrintNumber(m, n);

void PrintNumber(int m, int n)
{
    if (n>m)
        for (int i = m; i <= n; i++)
            Console.Write($"{i} ");
    else
        for (int i = n; i <= m; i++)
            Console.Write($"{i} ");
}