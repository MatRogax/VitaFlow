using projeto_carlos.Models;

namespace projeto_carlos.Services;

public interface IJournalService
{
    IReadOnlyList<JournalEntry> GetEntries();
    void AddEntry(JournalEntry entry);
}

public class JournalService : IJournalService
{
    private readonly List<JournalEntry> _entries = new();

    public IReadOnlyList<JournalEntry> GetEntries()
    {
        return _entries.OrderByDescending(e => e.Date).ToList();
    }

    public void AddEntry(JournalEntry entry)
    {
        if (entry == null) throw new ArgumentNullException(nameof(entry));
        _entries.Add(entry);
    }
}
