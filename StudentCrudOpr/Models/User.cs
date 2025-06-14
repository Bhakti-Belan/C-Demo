namespace StudentCrudOpr.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public virtual UserProfile Profile { get; set; }
    }
}
