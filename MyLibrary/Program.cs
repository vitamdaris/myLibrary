using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{


    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Book> listOfBooksByAuthors = new Dictionary<int, Book>();
            Author benjamin = new Author();
            Book b = new Book("C# in nutshell", benjamin, 50, "English", 1231515, "232313113", typeOfGenre.Drama); 

            listOfBooksByAuthors.Add(1, b);

            Repository<Book> a = new Repository<Book>();
            a.Insert(b);
            a.GetAll();
            Console.ReadKey();
        }
    }
}
