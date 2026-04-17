namespace projeto_carlos.Models.Entities;

public class SessionModel
{
    public int Id { get; set; }
    public PsychologistModel Psychologist { get; set; } = default!;
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string Status { get; set; } = string.Empty;
    public string? StatusLabel { get; set; }
    public bool IsCompleted { get; set; }
    public bool CanJoin => !IsCompleted && Date.Date <= DateTime.Now.Date.AddDays(1);
}
