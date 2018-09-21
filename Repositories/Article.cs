using Dapper.Contrib.Extensions;

namespace Blog.Repositories
{
    [Table("Article")]
    public class Article: EntityBase
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}