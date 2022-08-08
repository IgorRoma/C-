//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] num = new int[4];

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int PosNum(int[] array)
{
    int posn = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            posn++;
        }
    }
    return posn;
}

FillArray(num, 100, 1000);
WriteArray(num);
Console.WriteLine();

int posn = PosNum(num);
Console.WriteLine($"Количество чётных чисел в массиве: {posn}");