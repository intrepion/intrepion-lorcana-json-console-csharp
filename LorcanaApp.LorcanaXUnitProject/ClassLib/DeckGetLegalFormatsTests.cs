using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class DeckGetLegalFormatsTests
{
    [Fact]
    public void GetLegalFormats_EmptyDeck_EmptyList()
    {
        var expected = 0;
        var deck = new Deck();

        var formats = deck.GetLegalFormats();
        var actual = formats.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalFormats_Inks3_EmptyList()
    {
        var expected = 0;
        var deck = Deck.GetDeck(Format.Demo, "GAMA 2023 - Sapphire / Steel").Clone();

        deck.AddCard(Card.GetCard("CHESHIRE CAT", "Not All There"));
        var formats = deck.GetLegalFormats();
        var actual = formats.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalFormats_DeckDemoCards4Unique1_EmptyList()
    {
        var expected = 0;
        var deck = Deck.GetDeck(Format.Demo, "GAMA 2023 - Amber / Amethyst");

        deck.AddCard(Card.GetCard("FRIENDS ON THE OTHER SIDE", null));
        var formats = deck.GetLegalFormats();
        var actual = formats.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalFormats_DeckDemo_FormatDemo()
    {
        var expected = 1;
        var deck = Deck.GetDeck(Format.Demo, "GAMA 2023 - Sapphire / Steel");

        var formats = deck.GetLegalFormats();
        var actual = formats.Count;

        Assert.Equal(expected, actual);
    }
}
