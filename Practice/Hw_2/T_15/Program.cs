//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите целое число соответствующее дню недели: ");

int n = Convert.ToInt32(Console.ReadLine());
{
    switch (n)
    {
        case 6:
            Console.WriteLine("Cуббота - выходной день");
            break;
        case 7:
            Console.WriteLine("Воскресенье - выходной день");
            break;
        default:
            Console.WriteLine("Будни");
            break;
    }
}