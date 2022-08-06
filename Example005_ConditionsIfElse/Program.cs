Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "ирик")
{
    Console.WriteLine("Здравствуйте, Господин!");
}
else
{
    Console.Write("Ты кто такой, {0}?", username);
}