//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] arrReNum = new double[5];

for (int i = 0; i < arrReNum.Length; i++ )
{
    arrReNum[i] = new Random().Next(1, 10);
    Console.Write(arrReNum[i] + " ");
}

double maxNumber = arrReNum[0];
double minNumber = arrReNum[0];

for (int i = 1; i < arrReNum.Length; i++)
{
    if (maxNumber < arrReNum[i])
    {
        maxNumber = arrReNum[i];
    }
    if (minNumber > arrReNum[i])
    {
        minNumber = arrReNum[i];
    }
    
}
Console.WriteLine();

double dif = maxNumber - minNumber;
Console.WriteLine($"\nРазница максимального {maxNumber} и минимального {minNumber} элементов массива равна: {dif}");