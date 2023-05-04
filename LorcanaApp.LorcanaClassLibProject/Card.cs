namespace LorcanaApp.LorcanaClassLibProject;

public class Card
{
    public List<Classification>? Classifications { get; set; }
    public int? Cost { get; set; }
    public bool? Inkable { get; set; }
    public int? LoreValue { get; set; }
    public string? Name { get; set; }
    public int? Strength { get; set; }
    public CardType? Type { get; set; }
    public string? Version { get; set; }
    public int? Willpower { get; set; }

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
        if (Classifications == null)
        {
            return false;
        }

        if (Classifications.Count == 0)
        {
            return false;
        }

        if (Cost == null)
        {
            return false;
        }

        if (Inkable == null)
        {
            return false;
        }

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
            if (LoreValue == null)
            {
                return false;
            }

            if (Strength == null)
            {
                return false;
            }

            if (String.IsNullOrWhiteSpace(Version))
            {
                return false;
            }

            if (Willpower == null)
            {
                return false;
            }
        }

        return true;
    }
}
