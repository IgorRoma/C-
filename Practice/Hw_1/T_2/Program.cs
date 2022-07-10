//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите 2 различных числа для определения максимального и минимального: ");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());

double max = a;
double min = b;

if (b < max) 
{
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
if (b > max) 
{
    max = b;
    min = a;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
if (a == b)
{
    Console.Write("!!!Числа равны!!!");
}