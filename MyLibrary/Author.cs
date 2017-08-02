using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    public class Author:Person
    {
        private static int ID_AuthorStatic = 0;
        // ID_AuthorStatic is for set primaryKey for every author
        public int ID_Author
        {
            get => ID_Author;
            set
            {
                this.ID_Author = ID_AuthorStatic;
                ID_AuthorStatic++;
            }
        }
        //first, second name
        private int dateOfBirth { get; set; }
        private int dateOfDeath { get; set; }
        private string bibliography { get; set; }
        private int noOfBooks { get; set; } 

        public Author() { }

        public Author(string first, string second, int dateOfBirth, int dateOfDeath, string bibliography, int noOfBooks, int ID_Author) : base(first, second)
        {
            this.dateOfBirth = dateOfBirth;
            this.dateOfDeath = dateOfDeath;
            this.bibliography = bibliography;
            this.noOfBooks = noOfBooks;
            this.ID_Author = ID_Author;
        }
    }
}