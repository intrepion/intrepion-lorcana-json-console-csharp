using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class DeckGetLegalCardsToAddTests
{
    [Fact]
    public void GetLegalCardsToAdd_FormatDemo_AllCards()
    {
        var expected = 35;
        var deck = new Deck();

        var cards = deck.GetLegalCardsToAdd(Format.Demo);
        var actual = cards.Count;

        Assert.Equal(expected, actual);
    }
}
