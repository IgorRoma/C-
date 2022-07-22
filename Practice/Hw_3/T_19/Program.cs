//Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.

class Palindr
{
    public static bool Palindromtest (string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
 
                if (s[i] != s[s.Length - i - 1])
                    return false;
                return true;
 
        }
     
static void Main()
    {
        string s;
        Console.WriteLine("\nПроверка на палиндром\n\nВведите целое, положительное, пятизначное число:");
        s = Console.ReadLine();
            if (Palindromtest(s)) Console.WriteLine("Эта строка - палиндром");
            else Console.WriteLine("Эта строка - не палиндром");
    }
}
