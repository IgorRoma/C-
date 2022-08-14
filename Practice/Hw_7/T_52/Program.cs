//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

Console.Write("Задайте двумерный массив:\n");

Console.Write("\nВведите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] array = new double[m, n];
CreateArrayDouble(array);

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
}

void WriteArray (double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}

int[,] arrayWhole = new int[m, n];
arrayWhole = TransformationArrayWhole(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < m; j++)
    {
        arithmeticMean += arrayWhole[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / m, 1);
    Console.WriteLine($"столбца №{i+1}: {arithmeticMean}");
}

int[,] TransformationArrayWhole (double[,] array)
{
    int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
        }
    }
    return arrayWhole;
}

void WriteArrayInt (int[,] arrayWhole)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arrayWhole[i, j] + " ");
        }
        Console.WriteLine();
    }
}