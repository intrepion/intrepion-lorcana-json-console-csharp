using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class GameGetLegalFormatsTests
{
    [Fact]
    public void GetLegalFormats_EmptyGame_EmptyList()
    {
        var game = new Game();

        var legalFormats = game.GetLegalFormats();
    }
}
