namespace LorcanaApp.LorcanaClassLibProject;

public class Deck
{
    private List<Card> _cards { get; set; } = new List<Card>();
    public static List<Deck> AllDecks { get; set; }
    public string? Name { get; set; }

    static Deck()
    {
        AllDecks = new List<Deck>();

        var gama2023SapphireSteel = new Deck();
        gama2023SapphireSteel.Name = "GAMA 2023 - Sapphire / Steel";
        gama2023SapphireSteel.AddCard(Card.GetCard("GOONS", "Maleficent's Underlings"));
        gama2023SapphireSteel.AddCard(Card.GetCard("GOONS", "Maleficent's Underlings"));
        gama2023SapphireSteel.AddCard(Card.GetCard("FLOUNDER", "Voice of Reason"));
        gama2023SapphireSteel.AddCard(Card.GetCard("FLOUNDER", "Voice of Reason"));
        gama2023SapphireSteel.AddCard(Card.GetCard("CAPTAIN HOOK", "Forceful Duelist"));
        gama2023SapphireSteel.AddCard(Card.GetCard("CAPTAIN HOOK", "Forceful Duelist"));
        gama2023SapphireSteel.AddCard(Card.GetCard("CAPTAIN HOOK", "Forceful Duelist"));
        gama2023SapphireSteel.AddCard(Card.GetCard("AURORA", "Regal Princess"));
        gama2023SapphireSteel.AddCard(Card.GetCard("AURORA", "Regal Princess"));
        gama2023SapphireSteel.AddCard(Card.GetCard("AURORA", "Regal Princess"));
        gama2023SapphireSteel.AddCard(Card.GetCard("PRINCE ERIC", "Dashing and Brave"));
        gama2023SapphireSteel.AddCard(Card.GetCard("PRINCE ERIC", "Dashing and Brave"));
        gama2023SapphireSteel.AddCard(Card.GetCard("KRISTOFF", "Official Ice Master"));
        gama2023SapphireSteel.AddCard(Card.GetCard("KRISTOFF", "Official Ice Master"));
        gama2023SapphireSteel.AddCard(Card.GetCard("JASMINE", "Disguised"));
        gama2023SapphireSteel.AddCard(Card.GetCard("JASMINE", "Disguised"));
        gama2023SapphireSteel.AddCard(Card.GetCard("AURORA", "Briar Rose"));
        gama2023SapphireSteel.AddCard(Card.GetCard("AURORA", "Briar Rose"));
        gama2023SapphireSteel.AddCard(Card.GetCard("AURORA", "Briar Rose"));
        gama2023SapphireSteel.AddCard(Card.GetCard("MALEFICENT", "Sinister Visitor"));
        gama2023SapphireSteel.AddCard(Card.GetCard("MALEFICENT", "Sinister Visitor"));
        gama2023SapphireSteel.AddCard(Card.GetCard("MALEFICENT", "Sinister Visitor"));
        gama2023SapphireSteel.AddCard(Card.GetCard("AURORA", "Dreaming Guardian"));
        gama2023SapphireSteel.AddCard(Card.GetCard("BEAST", "Hardheaded"));
        gama2023SapphireSteel.AddCard(Card.GetCard("BEAST", "Hardheaded"));
        gama2023SapphireSteel.AddCard(Card.GetCard("SCAR", "Mastermind"));
        gama2023SapphireSteel.AddCard(Card.GetCard("DEVELOP YOUR BRAIN", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("DEVELOP YOUR BRAIN", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("DEVELOP YOUR BRAIN", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("FIRE THE CANNONS!", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("FIRE THE CANNONS!", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("ONE JUMP AHEAD", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("ONE JUMP AHEAD", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("SMASH", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("SMASH", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("FRYING PAN", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("FRYING PAN", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("COCONUT BASKET", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("COCONUT BASKET", null));
        gama2023SapphireSteel.AddCard(Card.GetCard("COCONUT BASKET", null));

        AllDecks.Add(gama2023SapphireSteel);

        var gama2023AmberAmethyst = new Deck();

        gama2023AmberAmethyst.Name = "GAMA 2023 - Amber / Amethyst";
        gama2023AmberAmethyst.AddCard(Card.GetCard("OLAF", "Friendly Snowman"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("OLAF", "Friendly Snowman"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("OLAF", "Friendly Snowman"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("STITCH", "New Dog"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("STITCH", "New Dog"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("STITCH", "New Dog"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("ARIEL", "On Human Legs"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("ARIEL", "On Human Legs"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("PASCAL", "Rapunzel's Companion"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("PASCAL", "Rapunzel's Companion"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("HEIHEI", "Boat Snack"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("HEIHEI", "Boat Snack"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("DR. FACILIER", "Charlatan"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("DR. FACILIER", "Charlatan"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MAGIC BROOM", "Bucket Brigade"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MAGIC BROOM", "Bucket Brigade"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MAGIC BROOM", "Bucket Brigade"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MINNIE MOUSE", "Beloved Princess"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MINNIE MOUSE", "Beloved Princess"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MINNIE MOUSE", "Beloved Princess"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("YZMA", "Alchemist"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("YZMA", "Alchemist"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("THE WARDROBE", "Belle's Confidant"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("THE WARDROBE", "Belle's Confidant"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("THE WARDROBE", "Belle's Confidant"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MICKEY MOUSE", "True Friend"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MICKEY MOUSE", "True Friend"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MICKEY MOUSE", "True Friend"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MAXIMUS", "Relentless Pursuer"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MAXIMUS", "Relentless Pursuer"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("JAFAR", "Wicked Sorcerer"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("DINGLEHOPPER", null));
        gama2023AmberAmethyst.AddCard(Card.GetCard("DINGLEHOPPER", null));
        gama2023AmberAmethyst.AddCard(Card.GetCard("CONTROL YOUR TEMPER!", null));
        gama2023AmberAmethyst.AddCard(Card.GetCard("CONTROL YOUR TEMPER!", null));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MALEFICENT", "Sorceress"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("MALEFICENT", "Sorceress"));
        gama2023AmberAmethyst.AddCard(Card.GetCard("FRIENDS ON THE OTHER SIDE", null));
        gama2023AmberAmethyst.AddCard(Card.GetCard("FRIENDS ON THE OTHER SIDE", null));
        gama2023AmberAmethyst.AddCard(Card.GetCard("FRIENDS ON THE OTHER SIDE", null));

        AllDecks.Add(gama2023AmberAmethyst);
    }

    public static Deck GetDeck(Format format, string name)
    {
        var deck = AllDecks.Find(d => d.Name == name && d.GetLegalFormats().Contains(format));

        if (deck == null)
        {
            return new Deck();
        }

        return deck;
    }

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }

    public Deck Clone()
    {
        var deck = new Deck();
        deck.Name = Name;
        deck._cards = new List<Card>(_cards);
        return deck;
    }

    public List<Card> GetLegalCardsToAdd(Format format)
    {
        if (Card.AllCards.Any(c1 => _cards.FindAll(c2 => c1 == c2).Count > 3))
        {
            return new List<Card>();
        }

        var inkTypes = new List<InkType>();
        _cards.ForEach(c =>
        {
            if (c.Ink != null && (inkTypes.Contains((InkType)c.Ink) == false))
            {
                inkTypes.Add((InkType)c.Ink);
            }
        });

        if (inkTypes.Count > 2)
        {
            return new List<Card>();
        }

        List<Card> legalCards;

        if (inkTypes.Count == 2)
        {
            legalCards = Card.AllCards
                .Where(
                    c1 =>
                        c1.Ink != null
                        && inkTypes.Contains((InkType)c1.Ink)
                        && _cards.FindAll(c2 => c1 == c2).Count < 3
                )
                .ToList();

            return legalCards;
        }

        legalCards = Card.AllCards.Where(c1 => _cards.FindAll(c2 => c1 == c2).Count < 3).ToList();

        return legalCards;
    }

    public List<Format> GetLegalFormats()
    {
        if (_cards.Count < 40)
        {
            return new List<Format>();
        }

        var inkTypes = new List<InkType>();
        _cards.ForEach(c =>
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

        return new List<Format> { Format.Demo };
    }
}
