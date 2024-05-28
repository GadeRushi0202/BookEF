using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace BookEF.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string? name { get; set; }
        [Required]
        public string? author { get; set; }

        [Required]
        public int price { get; set; }  
    }
}
