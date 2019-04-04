using System.Collections.Generic;

namespace DAL.Abstract
{
    public interface IRepository<T> where T : class, new()
    {
        List<T> GetAll();
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        T GetById(int id);
    }
}
