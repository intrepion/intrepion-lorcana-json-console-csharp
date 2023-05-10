using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class GameGetHistoryTests
{
    [Fact]
    public void GetHistory_GameEmpty_ListEmpty()
    {
        var game = new Game();

        var _ = game.GetHistory();
    }
}
