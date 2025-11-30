using BeFit.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFit.Models
{

    public class ExConn
    {
        [Key]
        public int ConnId { get; set; }

        [ForeignKey(nameof(ExType))]
        [Display(Name = "Typ ćwiczenia")]
        public int TypeId { get; set; }
        public ExType? ExType { get; set; }

        [ForeignKey(nameof(SessionInfo))]
        [Display(Name = "Sesja treningowa")]
        public int SessionId { get; set; }
        public SessionInfo? SessionInfo { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Liczba serii musi być od 1 do 100.")]
        [Display(Name = "Liczba serii")]
        public int Sets { get; set; }

        [Required]
        [Range(1, 500, ErrorMessage = "Powtórzenia w serii muszą być od 1 do 500.")]
        [Display(Name = "Powtórzeń w serii")]
        public int RepsPerSet { get; set; }

        [Required]
        [Range(0, 500, ErrorMessage = "Obciążenie musi być w zakresie 0–500 kg.")]
        [Display(Name = "Obciążenie (kg)")]
        public double Load { get; set; }

        [Required]
        [Display(Name = "Utworzone przez")]
        public string CreatedById { get; set; } = string.Empty;

        [ForeignKey(nameof(CreatedById))]
        public AppUser? CreatedBy { get; set; }

    }
}