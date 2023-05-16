using System.ComponentModel.DataAnnotations;

namespace LinqAspCore.Models
{
    public class Country
    {
        [Key]
        public int CId { get; set; }
        public string? Name { get; set; }
    }
}
