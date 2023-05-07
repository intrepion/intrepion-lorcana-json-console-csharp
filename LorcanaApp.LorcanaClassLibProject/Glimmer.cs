namespace LorcanaApp.LorcanaClassLibProject;

public class Glimmer
{
    public static List<Glimmer> AllGlimmers { get; set; }
    public List<Classification>? Classifications { get; set; }
    public int? Cost { get; set; }
    public InkType? Ink { get; set; }
    public bool? InkwellIcon { get; set; }
    public int? LoreValue { get; set; }
    public string? Name { get; set; }
    public int? Strength { get; set; }
    public GlimmerType? Type { get; set; }
    public string? Version { get; set; }
    public int? Willpower { get; set; }

    static Glimmer()
    {
        AllGlimmers = new List<Glimmer>
        {
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "On Human Legs",
                Willpower = 4,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Briar Rose",
                Willpower = 5,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Dreaming Guardian",
                Willpower = 5,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Regal Princess",
                Willpower = 2,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Hardheaded",
                Willpower = 4,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Forceful Duelist",
                Willpower = 2,
            },
            new Glimmer
            {
                Classifications = new List<Classification> { Classification.Storyborn, },
                Cost = 3,
                Ink = InkType.Emerald,
                InkwellIcon = true,
                LoreValue = 2,
                Name = "CHESHIRE CAT",
                Strength = 0,
                Type = GlimmerType.Character,
                Version = "Not All There",
                Willpower = 3,
            },
            new Glimmer
            {
                Classifications = new List<Classification> { Classification.Item },
                Cost = 2,
                Ink = InkType.Sapphire,
                InkwellIcon = true,
                Name = "COCONUT BASKET",
                Type = GlimmerType.Item,
            },
            new Glimmer
            {
                Classifications = new List<Classification> { Classification.Action, },
                Cost = 1,
                Ink = InkType.Amber,
                InkwellIcon = true,
                Name = "CONTROL YOUR TEMPER!",
                Type = GlimmerType.Action,
            },
            new Glimmer
            {
                Classifications = new List<Classification> { Classification.Action, },
                Cost = 1,
                Ink = InkType.Sapphire,
                InkwellIcon = true,
                Name = "DEVELOP YOUR BRAIN",
                Type = GlimmerType.Action,
            },
            new Glimmer
            {
                Classifications = new List<Classification> { Classification.Item, },
                Cost = 1,
                Ink = InkType.Amber,
                InkwellIcon = true,
                Name = "DINGLEHOPPER",
                Type = GlimmerType.Item,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Charlatan",
                Willpower = 4,
            },
            new Glimmer
            {
                Classifications = new List<Classification> { Classification.Action },
                Cost = 1,
                Ink = InkType.Steel,
                InkwellIcon = false,
                Name = "FIRE THE CANNONS!",
                Type = GlimmerType.Action,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Voice of Reason",
                Willpower = 2,
            },
            new Glimmer
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
                Type = GlimmerType.Song,
            },
            new Glimmer
            {
                Classifications = new List<Classification> { Classification.Item, },
                Cost = 2,
                Ink = InkType.Steel,
                InkwellIcon = true,
                Name = "FRYING PAN",
                Type = GlimmerType.Item,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Maleficent's Underlings",
                Willpower = 2,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Boat Snack",
                Willpower = 2,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Wicked Sorcerer",
                Willpower = 5,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Disguised",
                Willpower = 3,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Official Ice Master",
                Willpower = 3,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Bucket Brigade",
                Willpower = 2,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Sinister Visitor",
                Willpower = 4,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Sorceress",
                Willpower = 2,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Relentless Pursuer",
                Willpower = 3,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "True Friend",
                Willpower = 3,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Beloved Princess",
                Willpower = 3,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Friendly Snowman",
                Willpower = 3,
            },
            new Glimmer
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
                Type = GlimmerType.Song,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Rapunzel's Companion",
                Willpower = 1,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Dashing and Brave",
                Willpower = 3,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Mastermind",
                Willpower = 4,
            },
            new Glimmer
            {
                Classifications = new List<Classification> { Classification.Action, },
                Cost = 3,
                Ink = InkType.Steel,
                InkwellIcon = true,
                Name = "SMASH",
                Type = GlimmerType.Action,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "New Dog",
                Willpower = 2,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Belle's Confidant",
                Willpower = 4,
            },
            new Glimmer
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
                Type = GlimmerType.Character,
                Version = "Alchemist",
                Willpower = 2,
            }
        };
    }

    public static Glimmer GetGlimmer(string name, string? version)
    {
        Glimmer? glimmer;
        if (String.IsNullOrWhiteSpace(version))
        {
            glimmer = AllGlimmers.FirstOrDefault(c => name.Equals(c.Name));
        }
        else
        {
            glimmer = AllGlimmers.FirstOrDefault(
                c => name.Equals(c.Name) && version.Equals(c.Version)
            );
        }

        if (glimmer == null)
        {
            return new Glimmer();
        }

        return glimmer;
    }

    public Glimmer Clone()
    {
        return new Glimmer
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

        if (Type == GlimmerType.Action)
        {
            if (Classifications.Contains(Classification.Action) == false)
            {
                return false;
            }
        }
        else if (Type == GlimmerType.Character)
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
        else if (Type == GlimmerType.Item)
        {
            if (Classifications.Contains(Classification.Item) == false)
            {
                return false;
            }
        }
        else if (Type == GlimmerType.Song)
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
