using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa_API.Model
{
    public class VillaNumber
    {
        [Key ,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VillaNo { get; set; }

        public string? Details { get; set; }

        public DateTime? Date { get; set; }

    }
}
