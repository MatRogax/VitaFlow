namespace projeto_carlos.Models;

public class TimeSlot
{
    public TimeSpan Time { get; set; }
    public bool IsAvailable { get; set; }
    public bool IsSelected { get; set; }
}
