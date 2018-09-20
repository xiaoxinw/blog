using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Blog.Repositories;


namespace Blog.Controllers
{
    [Route("api/v1/articles")]
    public class ArticlesController: Controller
    {
        private readonly IRepository<Article> _repository;
        public ArticlesController(IRepository<Article> repo)
        {
            _repository = repo;
        }

        #region Routes
        [Route("")]
        public IEnumerable<Article> GetArticles()
        {
            return _repository.GetAll();
        }

        [Route("{id}")]
        public Article GetArticle(string id)
        {
            return _repository.Get(id);
        }
        #endregion
    }
}