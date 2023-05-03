using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class CardIsLegalTests
{
    [Fact]
    public void IsLegal_EmptyCard_False()
    {
        var card = new Card();

        var actual = card.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_EmptyName_False()
    {
        var card = new Card
        {
            Name = "",
        };

        var actual = card.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_WhitespaceName_False()
    {
        var card = new Card
        {
            Name = " ",
        };

        var actual = card.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_FullCard_True()
    {
        var card = new Card
        {
            Name = "Ariel",
        };

        var actual = card.IsLegal();

        Assert.True(actual);
    }
}
