//Напишите программу, которая на вход принимает 
//число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.WriteLine("Введите положительное число N: ");
double n = Convert.ToDouble(Console.ReadLine());

for (int i = 1; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + "  "); 
    }
}