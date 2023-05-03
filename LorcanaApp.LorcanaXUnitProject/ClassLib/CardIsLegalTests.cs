using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class CardIsLegalTests
{
    private Card _character { get; set; }

    public CardIsLegalTests()
    {
        _character = new Card
        {
            Name = "Ariel",
            Version = "On Human Legs",
        };
    }

    [Fact]
    public void IsLegal_EmptyCard_False()
    {
        var emptyCard = new Card();

        var actual = emptyCard.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_NullName_False()
    {
        _character.Name = null;

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_EmptyName_False()
    {
        _character.Name = "";

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_WhitespaceName_False()
    {
        _character.Name = " ";

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_FullCard_True()
    {
        var actual = _character.IsLegal();

        Assert.True(actual);
    }
}
