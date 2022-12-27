using System.ComponentModel.DataAnnotations;

namespace Villa_API.Model
{
    public class Villa
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

    }
}
