using System.ComponentModel.DataAnnotations;

namespace BeFit.Models
{
    public class SessionInfo
    {
        [Key] public int SessionId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Start { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime End { get; set; }
    }
}
