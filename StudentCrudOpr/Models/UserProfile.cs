namespace StudentCrudOpr.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }
        public string Bio { get; set; }
        public int UserId { get; set; }
        public virtual User user { get; set; }
    }
}
