using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace MyLibrary
{
    public class Repository<T> where T : Entity 

    {
        protected List<T> _myData = new List<T>();

        public void Insert(T entity)
        {
            _myData.Add(entity);
            Console.WriteLine("Everything is okay");

        }

        public void Delete(T entity)
        {
            _myData.Remove(entity);
        }

        public T GetById(int id)
        {
            return _myData.First(e => e.ID == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _myData;
        }
    }
}

