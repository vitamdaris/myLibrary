using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    public class User:Person,IUser
    {

        public User() { }
        public User(string name, string secondName):base(name,secondName) { }

        // methods
        public void addBook() { }


    }
}