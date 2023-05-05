namespace LorcanaApp.LorcanaClassLibProject;

public class Deck
{
    public List<Card> GetLegalCardsToAdd(Format format)
    {
        return Card.AllCards;
    }

    public void GetLegalFormats() { }
}
