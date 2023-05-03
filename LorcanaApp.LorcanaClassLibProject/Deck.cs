namespace LorcanaApp.LorcanaClassLibProject;

public class Deck
{
    public List<int> GetLegalCardsToAdd(Format format)
    {
        return Card.AllCards;
    }

    public void GetLegalFormats()
    {
    }
}
