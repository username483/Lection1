Console.Write("Введите имя пользовтеля:");
string username = Console.ReadLine();

if(username.ToLower() == "мaша")
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}