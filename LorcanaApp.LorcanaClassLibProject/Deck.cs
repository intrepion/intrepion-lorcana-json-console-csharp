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
        var inkTypes = new List<InkType>();
        _cards.ForEach(c =>
        {
            if (c.Ink != null && (inkTypes.Contains((InkType)c.Ink) == false))
            {
                inkTypes.Add((InkType)c.Ink);
            }
        });

        List<Card> legalCards;

        if (inkTypes.Count > 2)
        {
            return new List<Card>();
        }

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

    public void GetLegalFormats() { }
}
