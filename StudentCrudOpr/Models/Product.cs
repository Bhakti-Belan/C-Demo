using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCrudOpr.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        [MinLength(3)]
        [Column("Product Name")]
        public string Name { get; set; }
        [Required]
        public Double Price { get; set; }


    }
}
