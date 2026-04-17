namespace projeto_carlos.Models
{
    public class Meditation
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DurationMinutes { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Category { get; set; } = "Focus"; 
        public bool IsFeatured { get; set; }
        public string SubCategory { get; set; } = string.Empty; 
    }
}
