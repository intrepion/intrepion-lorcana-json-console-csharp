using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class CardIsLegalTests
{
    [Fact]
    public void IsLegal_EmptyCard_False()
    {
        var card = new Card();
    }
}
