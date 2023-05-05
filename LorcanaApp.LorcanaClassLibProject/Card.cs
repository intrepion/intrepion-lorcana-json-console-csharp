namespace LorcanaApp.LorcanaClassLibProject;

public class Card
{
    public List<Classification>? Classifications { get; set; }
    public int? Cost { get; set; }
    public InkType? Ink { get; set; }
    public bool? InkwellIcon { get; set; }
    public int? LoreValue { get; set; }
    public string? Name { get; set; }
    public int? Strength { get; set; }
    public CardType? Type { get; set; }
    public string? Version { get; set; }
    public int? Willpower { get; set; }

    public static List<Card> AllCards { get; } =
        new List<Card>
        {
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Hero,
                    Classification.Princess,
                    Classification.Storyborn,
                },
                Cost = 4,
                Ink = InkType.Amber,
                InkwellIcon = true,
                LoreValue = 2,
                Name = "ARIEL",
                Strength = 3,
                Type = CardType.Character,
                Version = "On Human Legs",
                Willpower = 4,
            },
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

    public static Card? GetCard(string name, string version)
    {
        return AllCards.FirstOrDefault(c => c.Name == name && c.Version == version);
    }

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

        if (Ink == null)
        {
            return false;
        }

        if (InkwellIcon == null)
        {
            return false;
        }

        if (String.IsNullOrWhiteSpace(Name))
        {
            return false;
        }

        if (Name.CompareTo(Name.ToUpperInvariant()) != 0)
        {
            return false;
        }

        if (Type == null)
        {
            return false;
        }

        if (Type == CardType.Action)
        {
            if (Classifications.Contains(Classification.Action) == false)
            {
                return false;
            }
        }
        else if (Type == CardType.Character)
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
        else if (Type == CardType.Item)
        {
            if (Classifications.Contains(Classification.Item) == false)
            {
                return false;
            }
        }
        else if (Type == CardType.Song)
        {
            if (Classifications.Contains(Classification.Action) == false)
            {
                return false;
            }

            if (Classifications.Contains(Classification.Song) == false)
            {
                return false;
            }
        }

        return true;
    }
}
