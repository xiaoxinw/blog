using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Blog.Repositories;


namespace Blog.Controllers
{
    [Route("api/v1/articles")]
    public class ArticlesController : Controller
    {
        private readonly IRepository<ArticleEntity> _repository;
        public ArticlesController(IRepository<ArticleEntity> repo)
        {
            _repository = repo;
        }

        #region Routes
        [Route("")]
        public IEnumerable<ArticleEntity> GetArticles()
        {
            return _repository.GetAll();
        }

        [Route("{id}")]
        public ArticleEntity GetArticle(string id)
        {
            return _repository.Get(id);
        }
        #endregion
    }
}