//Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.WriteLine("Введите число для определения, является ли оно чётным: ");
double a = Convert.ToDouble(Console.ReadLine());

if ((a % 2) == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}