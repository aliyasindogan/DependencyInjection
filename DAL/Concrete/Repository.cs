using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Concrete
{
    public class Repository<T, Context> : IRepository<T>
        where T : class, new()
        where Context : DbContext, new()
    {
        public List<T> GetAll()
        {
            using (Context context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Delete(T entity)
        {
            throw new NotImplementedException();
        }



        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
