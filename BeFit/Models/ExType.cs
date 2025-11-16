using System.ComponentModel.DataAnnotations;

namespace BeFit.Models
{
    public class ExType
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

    }
}
