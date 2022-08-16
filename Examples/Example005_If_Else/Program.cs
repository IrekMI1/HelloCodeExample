Console.Write("Ведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Урра, это Маша!");
}
else
{
    Console.Write($"Привет {username}");
}