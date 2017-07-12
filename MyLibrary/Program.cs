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
            Book b = new Book();

            listOfBooksByAuthors.Add(1, b);

            Repository<Book> a = new Repository<Book>();
            a.Insert(b);
            a.GetAll();
        }
    }
}
