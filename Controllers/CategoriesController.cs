using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Blog.Repositories;


namespace Blog.Controllers
{
    [Route("api/v1/categories")]
    public class CategoriesController : BaseApiController
    {
        private readonly IRepository<Category> _repository;
        public CategoriesController(IRepository<Category> repo)
        {
            _repository = repo;
        }

        #region Routes
        [HttpPost("")]
        public Category Create(Category cat)
        {
            _repository.Create(cat);
            return cat;
        }
        #endregion
    }
}