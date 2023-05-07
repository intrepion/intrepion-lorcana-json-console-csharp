using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class DeckListGetLegalGlimmersToAddTests
{
    [Fact]
    public void GetLegalGlimmersToAdd_FormatDemoNoGlimmers_AllGlimmers()
    {
        var expected = 36;
        var deckList = new DeckList();

        var glimmers = deckList.GetLegalGlimmersToAdd(Format.Demo);
        var actual = glimmers.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalGlimmersToAdd_FormatDemoGlimmers3Unique1_AllGlimmersMinus1()
    {
        var expected = 35;
        var deckList = new DeckList();
        var glimmer = Glimmer.GetGlimmer("AURORA", "Briar Rose");

        deckList.AddGlimmer(glimmer);
        deckList.AddGlimmer(glimmer);
        deckList.AddGlimmer(glimmer);

        var glimmers = deckList.GetLegalGlimmersToAdd(Format.Demo);
        var actual = glimmers.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalGlimmersToAdd_FormatDemoGlimmers3Unique3Inks3_NoGlimmers()
    {
        var expected = 0;
        var deckList = new DeckList();
        var glimmer1 = Glimmer.GetGlimmer("AURORA", "Briar Rose");
        var glimmer2 = Glimmer.GetGlimmer("BEAST", "Hardheaded");
        var glimmer3 = Glimmer.GetGlimmer("CHESHIRE CAT", "Not All There");

        deckList.AddGlimmer(glimmer1);
        deckList.AddGlimmer(glimmer2);
        deckList.AddGlimmer(glimmer3);

        var glimmers = deckList.GetLegalGlimmersToAdd(Format.Demo);
        var actual = glimmers.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalGlimmersToAdd_FormatDemoGlimmers4Unique1_NoGlimmers()
    {
        var expected = 0;
        var deckList = new DeckList();
        var glimmer = Glimmer.GetGlimmer("AURORA", "Briar Rose");

        deckList.AddGlimmer(glimmer);
        deckList.AddGlimmer(glimmer);
        deckList.AddGlimmer(glimmer);
        deckList.AddGlimmer(glimmer);

        var glimmers = deckList.GetLegalGlimmersToAdd(Format.Demo);
        var actual = glimmers.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalGlimmersToAdd_FormatDemoGlimmers6Unique2Inks2_AllGlimmersMinus1()
    {
        var expected = 16;
        var deckList = new DeckList();
        var glimmer1 = Glimmer.GetGlimmer("AURORA", "Briar Rose");
        var glimmer2 = Glimmer.GetGlimmer("BEAST", "Hardheaded");

        deckList.AddGlimmer(glimmer1);
        deckList.AddGlimmer(glimmer1);
        deckList.AddGlimmer(glimmer1);
        deckList.AddGlimmer(glimmer2);
        deckList.AddGlimmer(glimmer2);
        deckList.AddGlimmer(glimmer2);

        var glimmers = deckList.GetLegalGlimmersToAdd(Format.Demo);
        var actual = glimmers.Count;

        Assert.Equal(expected, actual);
    }
}
