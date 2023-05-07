using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class DeckGetLegalGlimmersToAddTests
{
    [Fact]
    public void GetLegalGlimmersToAdd_FormatDemoNoGlimmers_AllGlimmers()
    {
        var expected = 36;
        var deck = new Deck();

        var glimmers = deck.GetLegalGlimmersToAdd(Format.Demo);
        var actual = glimmers.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalGlimmersToAdd_FormatDemoGlimmers3Unique1_AllGlimmersMinus1()
    {
        var expected = 35;
        var deck = new Deck();
        var glimmer = Glimmer.GetGlimmer("AURORA", "Briar Rose");

        deck.AddGlimmer(glimmer);
        deck.AddGlimmer(glimmer);
        deck.AddGlimmer(glimmer);

        var glimmers = deck.GetLegalGlimmersToAdd(Format.Demo);
        var actual = glimmers.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalGlimmersToAdd_FormatDemoGlimmers3Unique3Inks3_NoGlimmers()
    {
        var expected = 0;
        var deck = new Deck();
        var glimmer1 = Glimmer.GetGlimmer("AURORA", "Briar Rose");
        var glimmer2 = Glimmer.GetGlimmer("BEAST", "Hardheaded");
        var glimmer3 = Glimmer.GetGlimmer("CHESHIRE CAT", "Not All There");

        deck.AddGlimmer(glimmer1);
        deck.AddGlimmer(glimmer2);
        deck.AddGlimmer(glimmer3);

        var glimmers = deck.GetLegalGlimmersToAdd(Format.Demo);
        var actual = glimmers.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalGlimmersToAdd_FormatDemoGlimmers4Unique1_NoGlimmers()
    {
        var expected = 0;
        var deck = new Deck();
        var glimmer = Glimmer.GetGlimmer("AURORA", "Briar Rose");

        deck.AddGlimmer(glimmer);
        deck.AddGlimmer(glimmer);
        deck.AddGlimmer(glimmer);
        deck.AddGlimmer(glimmer);

        var glimmers = deck.GetLegalGlimmersToAdd(Format.Demo);
        var actual = glimmers.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalGlimmersToAdd_FormatDemoGlimmers6Unique2Inks2_AllGlimmersMinus1()
    {
        var expected = 16;
        var deck = new Deck();
        var glimmer1 = Glimmer.GetGlimmer("AURORA", "Briar Rose");
        var glimmer2 = Glimmer.GetGlimmer("BEAST", "Hardheaded");

        deck.AddGlimmer(glimmer1);
        deck.AddGlimmer(glimmer1);
        deck.AddGlimmer(glimmer1);
        deck.AddGlimmer(glimmer2);
        deck.AddGlimmer(glimmer2);
        deck.AddGlimmer(glimmer2);

        var glimmers = deck.GetLegalGlimmersToAdd(Format.Demo);
        var actual = glimmers.Count;

        Assert.Equal(expected, actual);
    }
}
