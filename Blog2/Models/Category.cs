using Dapper.Contrib.Extensions;

namespace Blog2.Models
{
    [Table("[Category]")]
    public class Category
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
