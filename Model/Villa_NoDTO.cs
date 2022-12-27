using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa_API.Model
{
    public class Villa_NoDTO
    {
        [Required]
        public int VillaNo { get; set; }

        public string? Details { get; set; }
    }
}
