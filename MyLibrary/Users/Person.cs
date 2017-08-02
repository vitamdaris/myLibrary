using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    abstract public class Person
    {
        protected string firstName { get; set; }
        protected string secondName { get; set; }

        public Person() { }
        public Person(string name, string secondName)
        {
            this.firstName = name;
            this.secondName = secondName;
        }
    }
}