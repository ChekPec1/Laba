using ConsoleApp51;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
string music;
void PrintGreen(string message)
{
    ConsoleColor color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ForegroundColor = color;
}
void PrintPurple(string message)
{
    ConsoleColor color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = color;
}
void PrintBlue(string message)
{
    ConsoleColor color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(message);
    Console.ForegroundColor = color;
}

void PrintRed(string message)
{
    ConsoleColor color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = color;
}
PrintGreen("Привет, я программа которая расскажет тебе сколько ты слушаешь музыки и твою статистику");
PrintGreen("Введите номер команды");
MainServer server;

try
{
    server = new MainServer();
}
catch (Exception ex)
{
    PrintRed(ex.Message);
    Console.ReadKey();
    return;
}

while (true)
{
   
    switch (Console.ReadLine())
    {
        case "1":
             void AddMusic();
            break;







    }
}
