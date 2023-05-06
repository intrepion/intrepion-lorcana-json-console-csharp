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

    public static List<Card> AllCards { get; set; }

    static Card()
    {
        AllCards = new List<Card>
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
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Hero,
                    Classification.Princess,
                    Classification.Storyborn,
                },
                Cost = 4,
                Ink = InkType.Sapphire,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "AURORA",
                Strength = 2,
                Type = CardType.Character,
                Version = "Briar Rose",
                Willpower = 5,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Floodborn,
                    Classification.Hero,
                    Classification.Princess,
                },
                Cost = 5,
                Ink = InkType.Sapphire,
                InkwellIcon = true,
                LoreValue = 2,
                Name = "AURORA",
                Strength = 3,
                Type = CardType.Character,
                Version = "Dreaming Guardian",
                Willpower = 5,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Hero,
                    Classification.Princess,
                    Classification.Storyborn,
                },
                Cost = 2,
                Ink = InkType.Sapphire,
                InkwellIcon = true,
                LoreValue = 2,
                Name = "AURORA",
                Strength = 2,
                Type = CardType.Character,
                Version = "Regal Princess",
                Willpower = 2,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Hero,
                    Classification.Prince,
                    Classification.Storyborn,
                },
                Cost = 5,
                Ink = InkType.Steel,
                InkwellIcon = true,
                LoreValue = 2,
                Name = "BEAST",
                Strength = 4,
                Type = CardType.Character,
                Version = "Hardheaded",
                Willpower = 4,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Captain,
                    Classification.Dreamborn,
                    Classification.Pirate,
                    Classification.Villain,
                },
                Cost = 1,
                Ink = InkType.Steel,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "CAPTAIN HOOK",
                Strength = 1,
                Type = CardType.Character,
                Version = "Forceful Duelist",
                Willpower = 2,
            },
            new Card
            {
                Classifications = new List<Classification> { Classification.Item },
                Cost = 2,
                Ink = InkType.Sapphire,
                InkwellIcon = true,
                Name = "COCONUT BASKET",
                Type = CardType.Item,
            },
            new Card
            {
                Classifications = new List<Classification> { Classification.Action, },
                Cost = 1,
                Ink = InkType.Amber,
                InkwellIcon = true,
                Name = "CONTROL YOUR TEMPER",
                Type = CardType.Action,
            },
            new Card
            {
                Classifications = new List<Classification> { Classification.Action, },
                Cost = 1,
                Ink = InkType.Sapphire,
                InkwellIcon = true,
                Name = "DEVELOP YOUR BRAIN",
                Type = CardType.Action,
            },
            new Card
            {
                Classifications = new List<Classification> { Classification.Item, },
                Cost = 1,
                Ink = InkType.Amber,
                InkwellIcon = true,
                Name = "DINGLEHOPPER",
                Type = CardType.Item,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Sorcerer,
                    Classification.Storyborn,
                    Classification.Villain,
                },
                Cost = 2,
                Ink = InkType.Amethyst,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "DR. FACILIER",
                Strength = 0,
                Type = CardType.Character,
                Version = "Charlatan",
                Willpower = 4,
            },
            new Card
            {
                Classifications = new List<Classification> { Classification.Action },
                Cost = 1,
                Ink = InkType.Steel,
                InkwellIcon = false,
                Name = "FIRE THE CANNONS!",
                Type = CardType.Action,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Ally,
                    Classification.Storyborn,
                },
                Cost = 1,
                Ink = InkType.Sapphire,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "FLOUNDER",
                Strength = 2,
                Type = CardType.Character,
                Version = "Voice of Reason",
                Willpower = 2,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Action,
                    Classification.Song,
                },
                Cost = 3,
                Ink = InkType.Amethyst,
                InkwellIcon = true,
                Name = "FRIENDS ON THE OTHER SIDE",
                Type = CardType.Song,
            },
            new Card
            {
                Classifications = new List<Classification> { Classification.Item, },
                Cost = 2,
                Ink = InkType.Steel,
                InkwellIcon = true,
                Name = "FRYING PAN",
                Type = CardType.Item,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Ally,
                    Classification.Storyborn,
                },
                Cost = 1,
                Ink = InkType.Steel,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "GOONS",
                Strength = 2,
                Type = CardType.Character,
                Version = "Maleficent's Goons",
                Willpower = 2,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Ally,
                    Classification.Storyborn,
                },
                Cost = 1,
                Ink = InkType.Amber,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "HEIHEI",
                Strength = 1,
                Type = CardType.Character,
                Version = "Boat Snack",
                Willpower = 2,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Dreamborn,
                    Classification.Sorcerer,
                    Classification.Villain,
                },
                Cost = 4,
                Ink = InkType.Amethyst,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "JAFAR",
                Strength = 2,
                Type = CardType.Character,
                Version = "Wicked Sorcerer",
                Willpower = 5,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Princess,
                    Classification.Storyborn,
                },
                Cost = 3,
                Ink = InkType.Sapphire,
                InkwellIcon = true,
                LoreValue = 2,
                Name = "JASMINE",
                Strength = 3,
                Type = CardType.Character,
                Version = "Disguised",
                Willpower = 3,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Ally,
                    Classification.Storyborn,
                },
                Cost = 3,
                Ink = InkType.Steel,
                InkwellIcon = true,
                LoreValue = 2,
                Name = "KRISTOFF",
                Strength = 3,
                Type = CardType.Character,
                Version = "Official Ice Master",
                Willpower = 3,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Broom,
                    Classification.Dreamborn,
                },
                Cost = 2,
                Ink = InkType.Amethyst,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "MAGIC BROOM",
                Strength = 2,
                Type = CardType.Character,
                Version = "Bucket Brigade",
                Willpower = 2,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Sorcerer,
                    Classification.Storyborn,
                    Classification.Villain,
                },
                Cost = 4,
                Ink = InkType.Sapphire,
                InkwellIcon = true,
                LoreValue = 2,
                Name = "MALEFICENT",
                Strength = 3,
                Type = CardType.Character,
                Version = "Sinister Visitor",
                Willpower = 4,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Sorcerer,
                    Classification.Storyborn,
                    Classification.Villain,
                },
                Cost = 3,
                Ink = InkType.Amethyst,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "MALEFICENT",
                Strength = 2,
                Type = CardType.Character,
                Version = "Sorceress",
                Willpower = 2,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Ally,
                    Classification.Dreamborn,
                },
                Cost = 3,
                Ink = InkType.Amber,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "MAXIMUS",
                Strength = 3,
                Type = CardType.Character,
                Version = "Relentless Pursuer",
                Willpower = 3,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Hero,
                    Classification.Storyborn,
                },
                Cost = 3,
                Ink = InkType.Amber,
                InkwellIcon = true,
                LoreValue = 2,
                Name = "MICKEY MOUSE",
                Strength = 3,
                Type = CardType.Character,
                Version = "True Friend",
                Willpower = 3,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Dreamborn,
                    Classification.Princess,
                },
                Cost = 2,
                Ink = InkType.Amber,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "MINNIE MOUSE",
                Strength = 2,
                Type = CardType.Character,
                Version = "Beloved Princess",
                Willpower = 3,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Ally,
                    Classification.Storyborn,
                },
                Cost = 1,
                Ink = InkType.Amethyst,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "OLAF",
                Strength = 1,
                Type = CardType.Character,
                Version = "Friendly Snowman",
                Willpower = 3,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Action,
                    Classification.Song,
                },
                Cost = 2,
                Ink = InkType.Sapphire,
                InkwellIcon = false,
                Name = "ONE JUMP AHEAD",
                Type = CardType.Song,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Ally,
                    Classification.Storyborn,
                },
                Cost = 1,
                Ink = InkType.Amethyst,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "PASCAL",
                Strength = 1,
                Type = CardType.Character,
                Version = "Rapunzel's Companion",
                Willpower = 1,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Hero,
                    Classification.Prince,
                    Classification.Storyborn,
                },
                Cost = 2,
                Ink = InkType.Steel,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "PRINCE ERIC",
                Strength = 1,
                Type = CardType.Character,
                Version = "Dashing and Brave",
                Willpower = 3,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Storyborn,
                    Classification.Villain,
                },
                Cost = 6,
                Ink = InkType.Sapphire,
                InkwellIcon = true,
                LoreValue = 2,
                Name = "SCAR",
                Strength = 5,
                Type = CardType.Character,
                Version = "Mastermind",
                Willpower = 4,
            },
            new Card
            {
                Classifications = new List<Classification> { Classification.Action, },
                Cost = 3,
                Ink = InkType.Steel,
                InkwellIcon = true,
                Name = "SMASH",
                Type = CardType.Action,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Alien,
                    Classification.Hero,
                    Classification.Storyborn,
                },
                Cost = 1,
                Ink = InkType.Amber,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "STITCH",
                Strength = 2,
                Type = CardType.Character,
                Version = "New Dog",
                Willpower = 2,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Ally,
                    Classification.Dreamborn,
                },
                Cost = 3,
                Ink = InkType.Amethyst,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "THE WARDROBE",
                Strength = 3,
                Type = CardType.Character,
                Version = "Belle's Confidant",
                Willpower = 4,
            },
            new Card
            {
                Classifications = new List<Classification>
                {
                    Classification.Dreamborn,
                    Classification.Sorcerer,
                    Classification.Villain,
                },
                Cost = 2,
                Ink = InkType.Amethyst,
                InkwellIcon = true,
                LoreValue = 1,
                Name = "YZMA",
                Strength = 2,
                Type = CardType.Character,
                Version = "Alchemist",
                Willpower = 2,
            }
        };
    }

    public static Card GetCard(string name, string? version)
    {
        Card? card;
        if (String.IsNullOrWhiteSpace(version))
        {
            card = AllCards.FirstOrDefault(c => name.Equals(c.Name));
        }
        else
        {
            card = AllCards.FirstOrDefault(c => name.Equals(c.Name) && version.Equals(c.Version));
        }

        if (card == null)
        {
            return new Card();
        }

        return card;
    }

    public Card Clone()
    {
        return new Card
        {
            Classifications = Classifications,
            Cost = Cost,
            Ink = Ink,
            InkwellIcon = InkwellIcon,
            LoreValue = LoreValue,
            Name = Name,
            Strength = Strength,
            Type = Type,
            Version = Version,
            Willpower = Willpower,
        };
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
