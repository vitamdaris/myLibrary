using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    public class Book : Manuscript
    {
        private bool? _borrowed;
        private bool? _borrowable;

        //properties
        public string title
        {
            get;
            set;
        }

        public int idAuthor
        {
            get;
            set;
        }

        public int NoOfPages { get; set; }

        public string language
        {
            get;
            set;
        }

        public int year
        {
            get;
            set;
        }


        public bool Borrowed
        {
            get;
            set;
        }
        public bool Borrowable
        {
            get;
            set;
        }
        public string ISBN
        {
            get;
            set;
        }
        public typeOfGenre genre
        {
            get;
            set;
        }




        //constructors
        public Book()
        {

        }

        public Book(string Title, string Language)
        {
            title = Title;
            language = Language;
        }

        public Book(string Title, string Language, int idAuthor)
        {
            title = Title;
            language = Language;
            this.idAuthor = idAuthor;
        }
        public Book(string paramTitle, int paramAuthor, int paramNoOfPages, string paramLanguage, int paramYear, string paramISBN,
            typeOfGenre paramGenre)
        {
            title = paramTitle;
            idAuthor = paramAuthor;
            NoOfPages = paramNoOfPages;
            language = paramLanguage;
            year = paramYear;
            ISBN = paramISBN;
            genre = paramGenre;


        }

        // methods
        public void ShowInfo() { }
        public Boolean IsBorrowable() { return Borrowable; }
        public Boolean IsBorrowed() { return Borrowed; }

    }
}