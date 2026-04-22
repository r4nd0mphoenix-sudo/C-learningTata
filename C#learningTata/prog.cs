using System;


class Book
{
    public string Name;
    public string Author;
    public int year;

    public Book(string name, string author, int year)
    {
        Name = name;
        Author = author;
        this.year = year;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"название книги {Name}, автор - {Author}, год выхода {year}");
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("1984", "Джордж Оруэл",1948);
        Book book2 = new Book("Игра престолов", "Джордж Мартин", 1996);
        //Book book1 = new Book();
        //book1.Name = "1984";
        //book1.Author = "Джордж Оруэл";
        //book1.year = 1948;


        //Book book2 = new Book();
        //book2.Name = "Игра престолов";
        //book2.Author = "Джордж Мартин";
        //book2.year = 1996;
        book1.PrintInfo();
        book2.PrintInfo();
    }
}