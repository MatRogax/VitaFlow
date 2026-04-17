using projeto_carlos.Common.Entities;

namespace projeto_carlos.Models.Entities;

public class Psychologist : BaseEntity
{
    public Guid? UserId { get; set; }
    public virtual User? User { get; set; }
    
    public string Name { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
    public double Note { get; set; }
    public int TotalEvaluations { get; set; }
    public string Avatar { get; set; } = "bg-teal-500"; 
    public string? ImageUrl { get; set; }
    public List<string> Tags { get; set; } = new();
}