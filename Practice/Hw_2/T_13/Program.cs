//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет. 

Console.Clear();

Console.WriteLine("Введите целое число: ");

int n = Convert.ToInt32(Console.ReadLine());

void Three() // третье число с проверкой, на знак и отсутствие
{
    if (n > 0) {} else { n = -n; }
    Console.Write("Третья цифра: ");
    Console.WriteLine(n>99 ? n.ToString()[2] : "отсутствует");
    Console.ReadKey(true);
}

Three(); 