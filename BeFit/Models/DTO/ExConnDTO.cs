using System.ComponentModel.DataAnnotations;

namespace BeFit.Models.DTO
{
    public class ExConnDTO
    {
        [Required]
        [Display(Name = "Typ ćwiczenia")]
        public int TypeId { get; set; }

        [Required]
        [Display(Name = "Sesja treningowa")]
        public int SessionId { get; set; }

        [Required]
        [Range(1, 100)]
        [Display(Name = "Liczba serii")]
        public int Sets { get; set; }

        [Required]
        [Range(1, 500)]
        [Display(Name = "Powtórzenia w serii")]
        public int RepsPerSet { get; set; }

        [Required]
        [Range(0, 500)]
        [Display(Name = "Obciążenie (kg)")]
        public double Load { get; set; }
    }
}
