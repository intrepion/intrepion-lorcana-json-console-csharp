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

    [Fact]
    public void GetLegalCardsToAdd_FormatDemoCards4SameCard_AllCardsMinus1()
    {
        var expected = 34;
        var deck = new Deck();
        var card = Card.GetCard("ARIEL", "On Human Legs");

        deck.AddCard(card);
    }
}
