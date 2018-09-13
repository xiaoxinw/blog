using System.Collections.Generic;

namespace Blog.Repositories
{
    public interface IRepository<T> where T: EntityBase
    {
        T Get(string id);
        IEnumerable<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}