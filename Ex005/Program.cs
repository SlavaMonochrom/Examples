﻿string username;

Console.Write("Введите имя пользователя: ");
username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же Маша!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}