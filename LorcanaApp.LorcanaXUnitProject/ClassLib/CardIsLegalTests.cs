using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class CardIsLegalTests
{
    [Fact]
    public void IsLegal_EmptyCard_False()
    {
        var card = new Card();

        var actual = card.IsLegal();
    }

    [Fact]
    public void IsLegal_FullCard_True()
    {
        var card = Card.MickeyMouseWaywardSorcerer;

        var actual = card.IsLegal();

        Assert.True(actual);
    }
}
