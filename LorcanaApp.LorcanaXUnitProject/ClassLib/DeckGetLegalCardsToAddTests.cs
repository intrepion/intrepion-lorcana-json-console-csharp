using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class DeckGetLegalCardsToAddTests
{
    [Fact]
    public void GetLegalCardsToAdd_FormatDemoNoCards_AllCards()
    {
        var expected = 36;
        var deck = new Deck();

        var cards = deck.GetLegalCardsToAdd(Format.Demo);
        var actual = cards.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalCardsToAdd_FormatDemoCards3Unique1_AllCardsMinus1()
    {
        var expected = 35;
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
    public void GetLegalCardsToAdd_FormatDemoCards3Unique3Inks3_NoCards()
    {
        var expected = 0;
        var deck = new Deck();
        var card1 = Card.GetCard("AURORA", "Briar Rose");
        var card2 = Card.GetCard("BEAST", "Hardheaded");
        var card3 = Card.GetCard("CHESHIRE CAT", "Not All There");

        deck.AddCard(card1);
        deck.AddCard(card2);
        deck.AddCard(card3);

        var cards = deck.GetLegalCardsToAdd(Format.Demo);
        var actual = cards.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalCardsToAdd_FormatDemoCards4Unique1_NoCards()
    {
        var expected = 0;
        var deck = new Deck();
        var card = Card.GetCard("AURORA", "Briar Rose");

        deck.AddCard(card);
        deck.AddCard(card);
        deck.AddCard(card);
        deck.AddCard(card);

        var cards = deck.GetLegalCardsToAdd(Format.Demo);
        var actual = cards.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalCardsToAdd_FormatDemoCards6Unique2Inks2_AllCardsMinus1()
    {
        var expected = 16;
        var deck = new Deck();
        var card1 = Card.GetCard("AURORA", "Briar Rose");
        var card2 = Card.GetCard("BEAST", "Hardheaded");

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
