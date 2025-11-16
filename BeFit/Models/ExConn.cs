using System.ComponentModel.DataAnnotations;

namespace BeFit.Models
{
    public class ExConn
    {
        [Key] public int ConnId { get; set; }
        public int TypeId { get; set; }
        public ExType ExType { get; set; }
        public int SessionId { get; set; }
        public SessionInfo SessionInfo { get; set; }

    }
}
