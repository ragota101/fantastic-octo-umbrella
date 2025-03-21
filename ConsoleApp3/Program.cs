﻿using System;
using System.Net;
using System.Xml.Linq;

class Firma
{
    // Поля класса
    public string Name { get; set; }      // Название фирмы
    public string Address { get; set; }   // Адрес фирмы
    public int FoundationYear { get; set; } // Год основания фирмы

    // Конструктор
    public Firma(string name, string address, int foundationYear)
    {
        Name = name;
        Address = address;
        FoundationYear = foundationYear;
    }
    public Firma()
    {
        Name = "Неизвестно";
        Address = "Неизвестно";
        FoundationYear = 0;
    }
    // Метод для вывода информации о фирме
    public void PrintInfo()
    {
        Console.WriteLine($"Название фирмы: {Name}");
        Console.WriteLine($"Адрес: {Address}");
        Console.WriteLine($"Год основания: {FoundationYear}");
    }
}
class Program
{
    static void Main()
    {
        // Создание объекта фирмы
        Firma firma1 = new Firma("ООО Пример", "Москва, ул. Ленина, 1", 2000);

        // Вывод информации о фирме
        firma1.PrintInfo();
    }
}