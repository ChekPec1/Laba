
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System;
using System.IO;
using System;
using System.Collections.Generic;


List<string> musics = new();

LoadListFromFile();
    void LoadListFromFile()
    {
        string _filePath = "musictracks.txt";
        if (File.Exists(_filePath))
        {
            musics = File.ReadAllLines(_filePath).ToList();
            PrintRed("Список треков загружен из файла");
        }
    }
string filePath = "musictracks.txt";
if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
    PrintRed("Файл для хранения музыки создан");
}



void SaveListToFile()
{
    string filePath = "musictracks.txt";
    File.WriteAllLines(filePath, musics);
    
}

void PrintGreen(string message)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
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
    PrintGreen("Вот список команд \n 0)Выход из программы \n 1)Добавление трека \n 2)Удаление трека \n 3)Список всех треков  \n 4)Очистить все записи \n 5)Help ");


AppDomain.CurrentDomain.ProcessExit += (_, _) => SaveListToFile();

while (true)
    {
    Console.Write("> ");
    string input = Console.ReadLine();
    switch (input)
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
        default:
            PrintRed("Неверная команда!");
            break;
            
        }

    }
    
void MusicAdd()
{
    PrintGreen("Напиши название");
    string track = Console.ReadLine();
    if (track == "")
    {
        PrintRed("Не правильно!");
    }
    else
    {
        musics.Add(track);
        SaveListToFile(); 
        PrintRed("Добавлено");
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
        musics.ForEach((track) => Console.WriteLine(track.ToString()));

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
        PrintGreen("\n 0)Выход из программы \n 1)Добавление трека \n 2)Удаление трека \n 3)Список всех треков  \n 4)Очистить все записи \n 5)Help ");
    }

void Exit()
{
    PrintGreen("Пока(");
    SaveListToFile();
    Environment.Exit(0);
}




