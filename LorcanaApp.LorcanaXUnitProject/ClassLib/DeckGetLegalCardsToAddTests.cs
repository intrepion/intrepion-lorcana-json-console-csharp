using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class DeckGetLegalCardsToAddTests
{
    [Fact]
    public void GetLegalCardsToAdd_FormatDemo_AllCards()
    {
        var deck = new Deck();

        var cards = deck.GetLegalCardsToAdd(Format.Demo);
    }
}
