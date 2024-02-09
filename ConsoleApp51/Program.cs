using ConsoleApp51;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
PrintGreen("Вот список команд \n 1)Добавление трека \n 2)Удаление трека \n 3)Список всех треков \n 4)Кол-во добавлений за определенный день \n 5)Список авторов  \n 6)Статистика активности \n 7)Очистить все записи \n 8)Сохранение записи \n 9)Help ");

while (true)
{
    switch (Console.ReadLine())
    {
        case "1":
            ;
            break;


    }

}


void MussicAdd()
{
    PrintGreen("Напиши трек который хочешь добавить");
    var treak = Console.ReadLine();
    PrintGreen("Напиши число");
    var day = Console.ReadLine();
    PrintGreen("Напиши месяц");
    var month = Console.ReadLine();
    
}

void MussicDelete()
{
    PrintGreen("Выбери id трека который хочешь удалить");




}
void MusicsList()
{

}
void MussicDay()
{

}
void MusicSave()
{

}
void Avtors()
{

}
void Activity()
{

}
void Commands()
{

}


            
        
            
    }

    
   





     
