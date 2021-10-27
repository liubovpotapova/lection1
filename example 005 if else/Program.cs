// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя");
string Username = Console.ReadLine();
if(Username.ToLower() =="маша")
{
    Console .WriteLine ("Машенька, привет!!!");
}
else
{
    Console .WriteLine ("Привет, ");
    Console .WriteLine (Username );
}