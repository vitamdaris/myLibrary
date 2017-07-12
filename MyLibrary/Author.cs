using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    public class Author:Person
    {
        // ID_AuthorStatic is for set primaryKey for every author

        //first, second name
        private int dateOfBirth;
        private int dateOfDeath;
        private string bibliography;
        private int noOfBooks;
        public int ID_Author;

    }
}