namespace PersonalWebsite.Data.Entities;

public record Publication
{
    private readonly Lazy<Uri?> _linkToDoi;
    
    public required IEnumerable<Author> Authors { get; init; }
    public required string ConferenceAbbreviation { get; init; }
    public required int ConferenceEditionNumber { get; init; }
    public required string ConferenceName { get; init; }
    public string? Doi { get; init; }
    public bool IsInfluential { get; init; } = false;
    public Uri? LinkToOpenAccess { get; init; }
    public Uri? LinkToCode { get; init; }
    public Uri? LinkToConference { get; init; }
    public Uri? LinkToJournal { get; init; }
    public required string Title { get; init; }
    public required DateOnly Date { get; init; }
    
    public Uri? LinkToDoi => _linkToDoi.Value;

    public Publication()
    {
        _linkToDoi = new Lazy<Uri?>(() => Doi != null ? new Uri($"https://doi.org/{Doi}") : null);
    }
}