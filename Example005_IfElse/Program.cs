Console.Write("Напишите свое имя ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{ 
    Console.WriteLine("Hey, Masha, how are you?");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}