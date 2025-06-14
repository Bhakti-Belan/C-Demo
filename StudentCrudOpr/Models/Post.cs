using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCrudOpr.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }

    }
}
