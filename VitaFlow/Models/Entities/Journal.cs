using projeto_carlos.Common.Entities;

namespace projeto_carlos.Models.Entities;

public class Journal : BaseEntity
{
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = default!;
    
    public DateTime Date { get; set; } = DateTime.Now;
    public string Emotion { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public List<string> Activities { get; set; } = new();
}
