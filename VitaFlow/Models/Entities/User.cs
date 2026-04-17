using projeto_carlos.Common.Entities;
using projeto_carlos.Enums;

namespace projeto_carlos.Models.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public EProfileType ProfileType { get; set; } = EProfileType.Patient;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual ICollection<Journal> Journals { get; set; } = new List<Journal>();
        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
