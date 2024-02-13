    using ConsoleApp51;
    using System.ComponentModel;
    using System.Diagnostics.Metrics;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography.X509Certificates;

    using ConsoleApp51;


    
    
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




    List<string> musics = new();
    PrintGreen("Привет, я программа которая расскажет тебе сколько ты слушаешь музыки и твою статистику");
            PrintGreen("Вот список команд \n 1)Добавление трека \n 2)Удаление трека \n 3)Список всех треков \n 4)Кол-во добавлений за определенный день \n 5)Статистика активности \n 6)Очистить все записи \n 7)Help ");



        while (true)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    MusicAdd();
                    break;
                case "2":
                    MussicDelete();
                    break;
                case "3":
                    MusicsList();
                    break;
                case "6":
                    Clear();
                    break;




            }

        }
      

    void MusicAdd()
            {
            
                PrintGreen("Напиши название");
                string treak = Console.ReadLine();
                if (treak == null)
                {
                    PrintRed("Не правильно!");
                }
                else
                {
                    musics.Add(treak);
                    PrintRed("Добавленно");
                }
                return;
            }


            void MussicDelete()
            {
        if (musics.Count() == null) return;
            PrintGreen("Выбери трек");
            musics.ForEach(treak => Console.WriteLine(treak));
        string delate = Console.ReadLine();
            PrintRed("Чтобы удалить введите слово: Удалить");
    if (Console.ReadLine() == "Удалить")
    {
        musics.Remove(delate);
        PrintRed("Выполнено");
        return;
    }
    else if (Console.ReadLine() != "Удалить")
            {
        PrintRed("Операция не выполнена");
        return;
            }
                }
            void MusicsList()
            {
            PrintGreen("Вот список всех добавленных треков:");
                  musics.ForEach((treak) => Console.WriteLine(treak.ToString()));
        return;
            }
            void MussicDay()
            {

            }
            void MusicSave()
            {

            }
            void Clear()
                {
            PrintRed("Внимание, этот метод удалит все записи, для очистки всех записей напишите: Выполнить");
    
            if (Console.ReadLine() == "Выполнить")
            {
                musics.Clear();
                PrintRed("Удаление всех списков завершенно");
            }
            else if (Console.ReadLine() != "Выполнить")
            {
                PrintRed("Операция не выполнена");
                return; 
            }
    return;
  
               }
            void Activity()
            {

            }
            void Commands()
            {

            }

    

        


            
        
              

    
   





     
