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
        protected List<T> _myData;


        public void Insert(T entity)
        {
             _myData.Add(entity);
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

