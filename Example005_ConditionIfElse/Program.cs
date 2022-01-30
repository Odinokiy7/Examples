Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "мама")
{
    Console.WriteLine("Ура, это же МАМА!");
}
else
{
    Console.Write("Ас саламу алейкум, ");
    Console.WriteLine(username);
}