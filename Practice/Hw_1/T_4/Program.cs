//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.Clear();

Console.WriteLine("Введите 3 различных числа для определения максимального: ");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

double max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);