using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa_API.Model
{
    public class Villa_DTO_Update
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]

        public string? Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Description { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

    }
}
