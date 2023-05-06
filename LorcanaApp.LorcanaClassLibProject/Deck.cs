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
        return Card.AllCards;
    }

    public void GetLegalFormats() { }
}
