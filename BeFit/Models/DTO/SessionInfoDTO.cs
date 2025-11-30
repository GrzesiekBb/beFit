using System.ComponentModel.DataAnnotations;

namespace BeFit.Models.DTO
{
    public class SessionInfoDTO : IValidatableObject
    {
        [Required]
        [Display(Name = "Początek sesji")]
        public DateTime Start { get; set; }

        [Required]
        [Display(Name = "Koniec sesji")]
        public DateTime End { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (End <= Start)
            {
                yield return new ValidationResult(
                    "Koniec sesji musi być później niż początek.",
                    new[] { nameof(End) });
            }
        }
    }
}
