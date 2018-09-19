using System;
using Microsoft.AspNetCore.Mvc;
using Blog.Repositories;


namespace Blog.Controllers
{
    public class ArticlesController: Controller
    {
        private readonly IRepository<Article> _repository;
        public ArticlesController(IRepository<Article> repo)
        {
            _repository = repo;
        }
    }
}