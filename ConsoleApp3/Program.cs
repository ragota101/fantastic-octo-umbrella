using System;

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

    // Метод для вывода информации о фирме
    public void PrintInfo()
    {
        Console.WriteLine($"Название фирмы: {Name}");
        Console.WriteLine($"Адрес: {Address}");
        Console.WriteLine($"Год основания: {FoundationYear}");
    }
}