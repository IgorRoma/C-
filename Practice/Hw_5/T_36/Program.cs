﻿//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

Console.Write("Введи количество элементов массива: ");
int elements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int elements, int min, int max)
{
    int[] randomNumbers = new int[elements];
    int sumElements = 0;
    Console.Write("\nПолучившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
        randomNumbers[i] = new Random().Next(min, max);
        Console.Write(randomNumbers[i] + " ");

        if (i % 2 != 1)
        {
            sumElements = sumElements + randomNumbers[i];
        }
    }
    return sumElements;
}

int randomNumbers =  RandomNumbers(elements, 1, 10);
Console.WriteLine();
Console.Write("\nСумма элементов, стоящих на нечётных позициях: " + (randomNumbers));