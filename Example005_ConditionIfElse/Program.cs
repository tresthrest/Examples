Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "сайхан")
{
    Console.WriteLine("Марша вохийла, Сайхан!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.Write("!");
}