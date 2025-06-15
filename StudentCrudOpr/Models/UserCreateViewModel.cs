using System.ComponentModel.DataAnnotations;

namespace StudentCrudOpr.Models
{
    public class UserCreateViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }
        public string FullName {  get; set; }
        public int Age {  get; set; }
    }
}
