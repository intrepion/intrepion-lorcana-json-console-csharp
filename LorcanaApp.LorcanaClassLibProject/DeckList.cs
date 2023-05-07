namespace LorcanaApp.LorcanaClassLibProject;

public class DeckList
{
    private List<Glimmer> _glimmers { get; set; } = new List<Glimmer>();
    public static List<DeckList> AllDeckLists { get; set; }
    public string? Name { get; set; }

    static DeckList()
    {
        AllDeckLists = new List<DeckList>();

        var gama2023SapphireSteel = new DeckList();
        gama2023SapphireSteel.Name = "GAMA 2023 - Sapphire / Steel";
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("GOONS", "Maleficent's Underlings"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("GOONS", "Maleficent's Underlings"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("FLOUNDER", "Voice of Reason"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("FLOUNDER", "Voice of Reason"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("CAPTAIN HOOK", "Forceful Duelist"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("CAPTAIN HOOK", "Forceful Duelist"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("CAPTAIN HOOK", "Forceful Duelist"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("AURORA", "Regal Princess"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("AURORA", "Regal Princess"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("AURORA", "Regal Princess"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("PRINCE ERIC", "Dashing and Brave"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("PRINCE ERIC", "Dashing and Brave"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("KRISTOFF", "Official Ice Master"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("KRISTOFF", "Official Ice Master"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("JASMINE", "Disguised"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("JASMINE", "Disguised"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("AURORA", "Briar Rose"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("AURORA", "Briar Rose"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("AURORA", "Briar Rose"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("MALEFICENT", "Sinister Visitor"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("MALEFICENT", "Sinister Visitor"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("MALEFICENT", "Sinister Visitor"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("AURORA", "Dreaming Guardian"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("BEAST", "Hardheaded"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("BEAST", "Hardheaded"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("SCAR", "Mastermind"));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("DEVELOP YOUR BRAIN", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("DEVELOP YOUR BRAIN", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("DEVELOP YOUR BRAIN", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("FIRE THE CANNONS!", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("FIRE THE CANNONS!", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("ONE JUMP AHEAD", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("ONE JUMP AHEAD", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("SMASH", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("SMASH", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("FRYING PAN", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("FRYING PAN", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("COCONUT BASKET", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("COCONUT BASKET", null));
        gama2023SapphireSteel.AddGlimmer(Glimmer.GetGlimmer("COCONUT BASKET", null));

        AllDeckLists.Add(gama2023SapphireSteel);

        var gama2023AmberAmethyst = new DeckList();

        gama2023AmberAmethyst.Name = "GAMA 2023 - Amber / Amethyst";
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("OLAF", "Friendly Snowman"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("OLAF", "Friendly Snowman"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("OLAF", "Friendly Snowman"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("STITCH", "New Dog"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("STITCH", "New Dog"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("STITCH", "New Dog"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("ARIEL", "On Human Legs"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("ARIEL", "On Human Legs"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("PASCAL", "Rapunzel's Companion"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("PASCAL", "Rapunzel's Companion"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("HEIHEI", "Boat Snack"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("HEIHEI", "Boat Snack"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("DR. FACILIER", "Charlatan"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("DR. FACILIER", "Charlatan"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MAGIC BROOM", "Bucket Brigade"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MAGIC BROOM", "Bucket Brigade"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MAGIC BROOM", "Bucket Brigade"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MINNIE MOUSE", "Beloved Princess"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MINNIE MOUSE", "Beloved Princess"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MINNIE MOUSE", "Beloved Princess"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("YZMA", "Alchemist"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("YZMA", "Alchemist"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("THE WARDROBE", "Belle's Confidant"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("THE WARDROBE", "Belle's Confidant"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("THE WARDROBE", "Belle's Confidant"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MICKEY MOUSE", "True Friend"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MICKEY MOUSE", "True Friend"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MICKEY MOUSE", "True Friend"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MAXIMUS", "Relentless Pursuer"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MAXIMUS", "Relentless Pursuer"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("JAFAR", "Wicked Sorcerer"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("DINGLEHOPPER", null));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("DINGLEHOPPER", null));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("CONTROL YOUR TEMPER!", null));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("CONTROL YOUR TEMPER!", null));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MALEFICENT", "Sorceress"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("MALEFICENT", "Sorceress"));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("FRIENDS ON THE OTHER SIDE", null));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("FRIENDS ON THE OTHER SIDE", null));
        gama2023AmberAmethyst.AddGlimmer(Glimmer.GetGlimmer("FRIENDS ON THE OTHER SIDE", null));

        AllDeckLists.Add(gama2023AmberAmethyst);
    }

    public static DeckList GetDeckList(Format format, string name)
    {
        var deckList = AllDeckLists.Find(
            d => d.Name == name && d.GetLegalFormats().Contains(format)
        );

        if (deckList == null)
        {
            return new DeckList();
        }

        return deckList;
    }

    public void AddGlimmer(Glimmer glimmer)
    {
        _glimmers.Add(glimmer);
    }

    public DeckList Clone()
    {
        var deckList = new DeckList();
        deckList.Name = Name;
        deckList._glimmers = new List<Glimmer>(_glimmers);
        return deckList;
    }

    public List<Glimmer> GetLegalGlimmersToAdd(Format format)
    {
        if (Glimmer.AllGlimmers.Any(c1 => _glimmers.FindAll(c2 => c1 == c2).Count > 3))
        {
            return new List<Glimmer>();
        }

        var inkTypes = new List<InkType>();
        _glimmers.ForEach(c =>
        {
            if (c.Ink != null && (inkTypes.Contains((InkType)c.Ink) == false))
            {
                inkTypes.Add((InkType)c.Ink);
            }
        });

        if (inkTypes.Count > 2)
        {
            return new List<Glimmer>();
        }

        List<Glimmer> legalGlimmers;

        if (inkTypes.Count == 2)
        {
            legalGlimmers = Glimmer.AllGlimmers
                .Where(
                    c1 =>
                        c1.Ink != null
                        && inkTypes.Contains((InkType)c1.Ink)
                        && _glimmers.FindAll(c2 => c1 == c2).Count < 3
                )
                .ToList();

            return legalGlimmers;
        }

        legalGlimmers = Glimmer.AllGlimmers
            .Where(c1 => _glimmers.FindAll(c2 => c1 == c2).Count < 3)
            .ToList();

        return legalGlimmers;
    }

    public List<Format> GetLegalFormats()
    {
        if (_glimmers.Count < 40)
        {
            return new List<Format>();
        }

        var inkTypes = new List<InkType>();
        _glimmers.ForEach(c =>
        {
            if (c.Ink != null && (inkTypes.Contains((InkType)c.Ink) == false))
            {
                inkTypes.Add((InkType)c.Ink);
            }
        });

        if (inkTypes.Count > 2)
        {
            return new List<Format>();
        }

        if (_glimmers.Any(c1 => _glimmers.FindAll(c2 => c1 == c2).Count > 3))
        {
            return new List<Format>();
        }

        return new List<Format> { Format.Demo };
    }
}
