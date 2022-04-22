using System.ComponentModel.DataAnnotations;
namespace TranHungDat.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = String.Empty;
    }
}
