﻿using System.ComponentModel.DataAnnotations;

namespace StudentCrudOpr.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public virtual UserProfile Profile { get; set; }
    }
}
