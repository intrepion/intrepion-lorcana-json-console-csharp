namespace LorcanaApp.LorcanaClassLibProject;

public class Deck
{
    private List<Card> _cards { get; set; } = new List<Card>();

    public void AddCard(Card card)
    {
        _cards.Add(card);
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

        return new List<Format> { Format.Demo };
    }
}
