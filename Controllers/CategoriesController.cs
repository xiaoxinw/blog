using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Blog.Repositories;
using Blog.Business;

namespace Blog.Controllers
{
    [Route("api/v1/categories")]
    public class CategoriesController : BaseApiController
    {
        private readonly IRepository<CategoryEntity> _repository;
        public CategoriesController(IRepository<CategoryEntity> repo)
        {
            _repository = repo;
        }

        #region Routes
        [HttpPost("")]
        public CategoryEntity Create(CategoryEntity entity)
        {
            return entity;
        }
        #endregion
    }
}