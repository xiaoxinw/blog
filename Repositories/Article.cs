namespace Blog.Repositories
{
    public class Article: EntityBase
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}