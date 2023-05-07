using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class DeckListGetLegalFormatsTests
{
    [Fact]
    public void GetLegalFormats_EmptyDeckList_EmptyList()
    {
        var expected = 0;
        var deckList = new DeckList();

        var formats = deckList.GetLegalFormats();
        var actual = formats.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalFormats_Inks3_EmptyList()
    {
        var expected = 0;
        var deckList = DeckList.GetDeckList(Format.Demo, "GAMA 2023 - Sapphire / Steel").Clone();

        deckList.AddGlimmer(Glimmer.GetGlimmer("CHESHIRE CAT", "Not All There"));
        var formats = deckList.GetLegalFormats();
        var actual = formats.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalFormats_DeckListDemoGlimmers4Unique1_EmptyList()
    {
        var expected = 0;
        var deckList = DeckList.GetDeckList(Format.Demo, "GAMA 2023 - Amber / Amethyst");

        deckList.AddGlimmer(Glimmer.GetGlimmer("FRIENDS ON THE OTHER SIDE", null));
        var formats = deckList.GetLegalFormats();
        var actual = formats.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalFormats_DeckListDemo_FormatDemo()
    {
        var expected = 1;
        var deckList = DeckList.GetDeckList(Format.Demo, "GAMA 2023 - Sapphire / Steel");

        var formats = deckList.GetLegalFormats();
        var actual = formats.Count;

        Assert.Equal(expected, actual);
    }
}
