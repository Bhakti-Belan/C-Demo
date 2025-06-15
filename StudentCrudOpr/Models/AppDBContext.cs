using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using StudentCrudOpr.Models;

namespace StudentCrudOpr.Models
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StudentCrudOpr.Models.UserCreateViewModel> UserCreateViewModel { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasKey(b => b.Id);
            modelBuilder.Entity<Book>()
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
   

}
