Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hooray, it's Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}