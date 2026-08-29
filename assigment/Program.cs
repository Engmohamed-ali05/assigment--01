

// 1st answer

namespace assigment


public class book { public string title; public int page; }



internal class Program
{
    static void Main(string[] args)
    {
        book book = new book();
        book.title = "cleancode";
        book.page = 464;
        object ob1 = book;
        Console.WriteLine(ob1);

