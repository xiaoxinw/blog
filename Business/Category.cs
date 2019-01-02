using System;
using Blog.Repositories;

namespace Blog.Business
{
    public class Category
    {
        public static CategoryEntity Create(CategoryEntity entity)
        {
            entity.Id = System.Guid.NewGuid().ToString("N");
            return entity;
        }
    }
}