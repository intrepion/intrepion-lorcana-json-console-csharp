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
        var legalCards = Card.AllCards
            .Where(c1 => _cards.FindAll(c2 => c1 == c2).Count < 3)
            .ToList();
        return legalCards;
    }

    public void GetLegalFormats() { }
}
