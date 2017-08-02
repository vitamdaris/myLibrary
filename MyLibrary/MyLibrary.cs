using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    public class MyLibrary
    {

        private Author[] author;
        private Book[] books;
        private User users;
        private Administrator administrators;
        private Moderator moderators;

        public MyLibrary() { }

        public MyLibrary(Author[] authors, Book[] books, User users, Administrator administrators, Moderator moderators)
        {

        }
    }
}