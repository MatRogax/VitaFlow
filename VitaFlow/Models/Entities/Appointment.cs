using projeto_carlos.Common.Entities;

namespace projeto_carlos.Models.Entities;

public class Appointment : BaseEntity
{
    public Guid PsychologistId { get; set; }
    public virtual Psychologist Psychologist { get; set; } = default!;
    
    public Guid PatientId { get; set; }
    public virtual User Patient { get; set; } = default!;

    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string Status { get; set; } = string.Empty;
    public string? StatusLabel { get; set; }
    public bool IsCompleted { get; set; }
    public bool CanJoin => !IsCompleted && Date.Date <= DateTime.Now.Date.AddDays(1);
}
