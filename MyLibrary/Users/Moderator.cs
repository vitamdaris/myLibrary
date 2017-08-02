using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    public class Moderator : User
    {

        public Moderator() { }
        public Moderator(string name, string secondName):base(name,secondName) { }
    }
}