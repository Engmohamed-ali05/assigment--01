

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

        //2 nd answer

        Console.WriteLine(book.ToString());
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(book.gettype());

        //3rd answer

        int page = 464;
        Console.WriteLine(page);

        //4th answer
        try
        {
            int result = 10 / 0;
            Console.WriteLine(result);
        }
        catch (Divide Exception)
        {
            Console.WriteLine("can notdivide");
        }
        finally
        {
            Console.WriteLine("done");
        }

        //5th answer
        int pageint = 300;
        double pagedouble = pageint;
        Console.WriteLine(pagedouble);
    }
}
