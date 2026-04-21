using System;


class Book
{
    public string Name;
    public string Author;
    public int year;

    public void PrintInfo()
    {
        Console.WriteLine($"название книги {Name}, автор - {Author}, год выхода {year}");
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book();
        book1.Name = "1984";
        book1.Author = "Джордж Оруэл";
        book1.year = 1948;
        book1.PrintInfo();

        Book book2 = new Book();
        book2.Name = "Игра престолов";
        book2.Author = "Джордж Мартин";
        book2.year = 1996;
        book2.PrintInfo();
    }
}