//Напишите программу, которая принимает на вход трёхзначное число и
//на выходе показывает вторую цифру этого числа. 

Console.Clear();

Console.WriteLine("Введите целое трёхзначное число: ");

int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
 n = (n / 10) % 10;    
}
else
{
 n = n * -1;   
 n = (n / 10) % 10;   
}

Console.Write("Вторая цифра: ");
Console.WriteLine(n);