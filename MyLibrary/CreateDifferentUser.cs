using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class Creator
    {
        public abstract Person Factory();
    }


    public class ConcreteUser : Creator
    {
        public override Person Factory()
        {
            return new User();
        }
    }


    public class ConcreteModerator : Creator
    {
        public override Person Factory()
        {
            return new Moderator();
        }
    }
}
