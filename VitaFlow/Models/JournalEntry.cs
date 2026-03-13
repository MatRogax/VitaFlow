namespace projeto_carlos.Models;

public class JournalEntry
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; } = DateTime.Now;
    public string Emotion { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public List<string> Activities { get; set; } = new();
}
