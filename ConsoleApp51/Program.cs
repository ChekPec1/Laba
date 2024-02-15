
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System;




    
    List<string> musics = new();
    void LoadListFromFile()
    {
    LoadListFromFile();
    string _filePath = "musictracks.txt";
        if (File.Exists(_filePath))
        {
            musics = File.ReadAllLines(_filePath).ToList();
            PrintRed("Список треков загружен из файла");
        }
    }
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
    PrintGreen("Вот список команд \n 0) Выход из программы \n 1)Добавление трека \n 2)Удаление трека \n 3)Список всех треков  \n 4)Очистить все записи \n 5)Help ");



    while (true)
    {
        switch (Console.ReadLine())
        {
        case "0":
            Exit();
            break;
            case "1":
                MusicAdd();
                break;
            case "2":
                MussicDelete();
                break;
            case "3":
                MusicsList();
                break;
            case "4":
                Clear();
                break;
            case "5":
                Commands();
                break;
        



        }

    }
    void SaveListToFile()
    {
        string filePath = "musictracks.txt";
        File.WriteAllLines(filePath, musics);
        PrintRed("Список треков сохранен в файл");
    }


    void MusicAdd()
    {

        PrintGreen("Напиши название");
        string treak = Console.ReadLine();
        if (treak == "")
        {
            PrintRed("Не правильно!");


        }

        else
        {
            musics.Add(treak);
            PrintRed("Добавленно");
            SaveListToFile();
        }

    }


    void MussicDelete()
    {
        if (musics.Count == 0)
        {
            PrintRed("У вас еще нет треков");
        }
        else
        {
            PrintGreen("Выбери трек");
            musics.ForEach(track => Console.WriteLine(track));
            string delete = Console.ReadLine();
            PrintRed("Чтобы удалить введите слово: Удалить");
            if (Console.ReadLine() == "Удалить")
            {
                musics.Remove(delete);
                PrintRed("Выполнено");
                SaveListToFile();
            }
            else
            {
                PrintRed("Операция не выполнена");
            }
        }
    }




    void MusicsList()
    {
        PrintGreen("Вот список всех добавленных треков:");
        musics.ForEach((treak) => Console.WriteLine(treak.ToString()));

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
        SaveListToFile();

    }
        else if (Console.ReadLine() != "Выполнить")
        {
            PrintRed("Операция не выполнена");

        }


    }
    void Commands()
    {
        PrintGreen("Вот список команд \n 1)Добавление трека \n 2)Удаление трека \n 3)Список всех треков \n 4)Кол-во добавлений за определенный день \n 5)Статистика активности \n 6)Очистить все записи \n 7)Help ");
    }

void Exit()
{
    SaveListToFile();
    Environment.Exit(0);
}





