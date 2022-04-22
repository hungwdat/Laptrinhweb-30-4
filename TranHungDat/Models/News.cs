using System.ComponentModel.DataAnnotations;

namespace TranHungDat.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(50)]
        public string Title { get; set; } = String.Empty;
        [Required]
        public string ImageUrl { get; set; } = String.Empty;
        [Required]
        [MaxLength(500)]
        [MinLength(100)]
        public string Content { get; set; } = String.Empty;
        [Required]

        public string Author { get; set; } = String.Empty;
        [Required]
        public DateTime CreateAt { get; set; }
        public String Category { get; set; } = String.Empty;
        [Required]
        public String Comment { get; set; } = String.Empty;

    }
}
