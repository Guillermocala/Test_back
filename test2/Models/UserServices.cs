using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateDb.Models
{
    [Keyless]
    public class UserServices
    {
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public DateTime AssignmentDate { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User user { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public virtual Service service { get; set; }
    }
}