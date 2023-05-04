namespace LorcanaApp.LorcanaClassLibProject;

public class Card
{
    public string? Name { get; set; }
    public CardType? Type { get; set; }
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
        if (String.IsNullOrWhiteSpace(Name))
        {
            return false;
        }

        if (Type == null)
        {
            return false;
        }

        if (Type == CardType.Character)
        {
            if (String.IsNullOrWhiteSpace(Version))
            {
                return false;
            }
        }

        return true;
    }
}
