using System;
using System.Collections.Generic;
using System.Text;

namespace ORM.Interfaces
{
     public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        T Get(T obj);
        void add(T obj);
        void Revome(T obj);
        void Update(T obj);

    }
}
