namespace PersonalWebsite.Data.Entities;

public record Publication
{
    public required IEnumerable<Author> Authors { get; init; }
    public required string ConferenceAbbreviation { get; init; }
    public required int ConferenceEditionNumber { get; init; }
    public required string ConferenceName { get; init; }
    public bool IsInfluential { get; init; } = false;
    public Uri? LinkToArxiv { get; init; }
    public Uri? LinkToCode { get; init; }
    public Uri? LinkToConference { get; init; }
    public Uri? LinkToJournal { get; init; }
    public required string Title { get; init; }
    public required DateOnly Date { get; init; }
}