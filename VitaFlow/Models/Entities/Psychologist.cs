namespace projeto_carlos.Models.Entities;

public class PsychologistModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
    public double Note { get; set; }
    public int TotalEvaluations { get; set; }
    public string Avatar { get; set; } = "bg-teal-500"; 
}