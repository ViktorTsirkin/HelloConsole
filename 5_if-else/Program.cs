Console.Write("Enter your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "виктор")
{
    Console.WriteLine("Ура, это же Витя!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}