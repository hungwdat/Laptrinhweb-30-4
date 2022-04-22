using System.ComponentModel.DataAnnotations;
namespace TranHungDat.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Author { get; set; } = String.Empty;
        [Required]
        public string Content { get; set; } = String.Empty;
        [Required]
        public DateTime CreateAt { get; set; }
    }
}
