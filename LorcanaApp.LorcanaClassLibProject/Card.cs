namespace LorcanaApp.LorcanaClassLibProject;

public class Card
{
    public CardType? CardType { get; set; }
    public string? Name { get; set; }
    public string? Version { get; set; }

    public static List<Card> AllCards { get; } = new List<Card>{
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
        new Card(),
    };

    public bool IsLegal()
    {
        return String.IsNullOrWhiteSpace(Name) == false;
    }
}
