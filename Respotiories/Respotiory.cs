using System.Data;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Blog;

namespace Blog.Repositories
{
    public class Repostory<T>:IRespotiory<T> where T: EntityBase
    {
        private DbContext _dbContext;
        public virtual T Get(string id)
        {
            using(IDbConnection con = _dbContext.GetConnection())
            {
                return con.Get<T>(id);
            }
        }
        public virtual IEnumerable<T> GetAll()
        {
            using(IDbConnection con = _dbContext.GetConnection())
            {
                return con.GetAll<T>();
            }
        }
        public virtual void Create(T entity)
        {
            using(IDbConnection con = _dbContext.GetConnection())
            {
                con.Insert(entity);
            }
        }
        public virtual void Update(T entity)
        {
            using(IDbConnection con = _dbContext.GetConnection())
            {
                con.Update(entity);
            }
        }
        public void Delete(T entity)
        {
            using(IDbConnection con = _dbContext.GetConnection())
            {
                con.Delete(entity);
            }
        }
    }
}