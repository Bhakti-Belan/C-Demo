namespace StudentCrudOpr.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
