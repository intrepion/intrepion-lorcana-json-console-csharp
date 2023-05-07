using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class GlimmerIsLegalTests
{
    [Fact]
    public void IsLegal_GlimmerEmpty_False()
    {
        var emptyGlimmer = new Glimmer();

        var actual = emptyGlimmer.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_GlimmerFull_True()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs");

        var actual = character.IsLegal();

        Assert.True(actual);
    }

    [Fact]
    public void IsLegal_ClassificationsEmpty_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Classifications = new List<Classification>();

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_ClassificationsNull_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Classifications = null;

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_CostNull_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Cost = null;

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_InkNull_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Ink = null;

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_InkwellIconNull_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.InkwellIcon = null;

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_NameEmpty_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Name = "";

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_NameNull_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Name = null;

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_NameNotUppercase_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Name = "Ariel";

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_NameWhitespace_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Name = " ";

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeActionClassificiationNoAction_False()
    {
        var action = Glimmer.GetGlimmer("CONTROL YOUR TEMPER!", null).Clone();
        action.Classifications = new List<Classification> { Classification.Item, };

        var actual = action.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterLoreValueNull_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.LoreValue = null;

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterStrengthNull_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Strength = null;

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterVersionEmpty_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Version = "";

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterVersionNull_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Version = null;

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterVersionWhitespace_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Version = " ";

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterWillpowerNull_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Willpower = null;

        var actual = character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeItemClassificationNoItem_False()
    {
        var item = Glimmer.GetGlimmer("DINGLEHOPPER", null).Clone();
        item.Classifications = new List<Classification> { Classification.Action, };

        var actual = item.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeSongClassificationNoAction_False()
    {
        var song = Glimmer.GetGlimmer("ONE JUMP AHEAD", null).Clone();
        song.Classifications = new List<Classification> { Classification.Song, };

        var actual = song.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeSongClassificationNoSong_False()
    {
        var song = Glimmer.GetGlimmer("ONE JUMP AHEAD", null).Clone();
        song.Classifications = new List<Classification> { Classification.Action, };

        var actual = song.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeNull_False()
    {
        var character = Glimmer.GetGlimmer("ARIEL", "On Human Legs").Clone();
        character.Type = null;

        var actual = character.IsLegal();

        Assert.False(actual);
    }
}
