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
    public void GetLegalCardsToAdd_FormatDemoCards3Same1Card_AllCardsMinus1()
    {
        var expected = 34;
        var deck = new Deck();
        var card = Card.GetCard("AURORA", "Briar Rose");

        deck.AddCard(card);
        deck.AddCard(card);
        deck.AddCard(card);

        var cards = deck.GetLegalCardsToAdd(Format.Demo);
        var actual = cards.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalCardsToAdd_FormatDemoCards6Same2Cards2Colors_AllCardsMinus1()
    {
        var expected = 16;
        var deck = new Deck();
        var card1 = Card.GetCard("AURORA", "Briar Rose");
        var card2 = Card.GetCard("CAPTAIN HOOK", "Forceful Duelist");

        deck.AddCard(card1);
        deck.AddCard(card1);
        deck.AddCard(card1);
        deck.AddCard(card2);
        deck.AddCard(card2);
        deck.AddCard(card2);

        var cards = deck.GetLegalCardsToAdd(Format.Demo);
        var actual = cards.Count;

        Assert.Equal(expected, actual);
    }
}
