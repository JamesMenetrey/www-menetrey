namespace PersonalWebsite.Data.Entities;

public record Author(string FirstName, string LastName)
{
    public static readonly Author Me = new("Jämes", "Ménétrey");
    public static readonly Author MarceloPasin = new("Marcelo", "Pasin");
    public static readonly Author PascalFelber = new("Pascal", "Felber");
    public static readonly Author ValerioSchiavoni = new("Valerio", "Schiavoni");
    
    public override string ToString() => $"{FirstName[0]}. {LastName}";

    public bool IsMe => this == Me;
}