using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class CardIsLegalTests
{
    private Card _card { get; set; }

    public CardIsLegalTests()
    {
        _card = new Card
        {
            Name = "Ariel",
            Version = "On Human Legs",
        };
    }

    [Fact]
    public void IsLegal_EmptyCard_False()
    {
        _card.Name = null;

        var actual = _card.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_EmptyName_False()
    {
        _card.Name = "";

        var actual = _card.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_WhitespaceName_False()
    {
        _card.Name = " ";

        var actual = _card.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_FullCard_True()
    {
        var actual = _card.IsLegal();

        Assert.True(actual);
    }
}
