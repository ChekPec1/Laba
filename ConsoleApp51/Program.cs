using ConsoleApp51;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


   
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
                AddMusic();
                break;
            case "2":
                DeleteMusic();
                break;



        }

    }

       

void AddMusic()
{
    List<string> Music = new();
    List<int> Day = new();
    List<int> Mount = new();
    List<int> Id = new();
    try
    {
        PrintGreen("Введите название трека");
        string music = Console.ReadLine();
        Music.Add(music);
        PrintGreen("Какой сегодня день");
        int day = Convert.ToInt32(Console.ReadLine());
        Day.Add(day);
        PrintGreen("Какой сегодня месяц");
        int mount = Convert.ToInt32(Console.ReadLine());   
        Mount.Add(mount);
       

    }
    catch (Exception ex)
    {
        PrintRed(ex.Message);
        Console.ReadKey();
        return;

    }
      
   

}


 void DeleteMusic()
{
    PrintGreen("Выберите id трека который хотите удалить");
    int Id = Convert.ToInt32(Console.ReadLine());
    PrintRed($"Для подтверждения введите слово: удалить ");
    string clear = Console.ReadLine();
    if (clear ==  "удалить")
    {

        server.Delete(Id);
        PrintRed("Удалено");
    }
    else
    {
        PrintRed("Не верно");
        return;
    }
    






}

