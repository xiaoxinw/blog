using Dapper.Contrib.Extensions;

namespace Blog.Repositories
{
    [Table("Category")]
    public class CategoryEntity : EntityBase
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string ParentId { get; set; }
    }
}