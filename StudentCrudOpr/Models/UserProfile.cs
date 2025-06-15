using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCrudOpr.Models
{
    public class UserProfile
    {
        [Key] public int Id { get; set; }
        public String FullName { get; set; }
        public int Age {  get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User user { get; set; }
    }
}
