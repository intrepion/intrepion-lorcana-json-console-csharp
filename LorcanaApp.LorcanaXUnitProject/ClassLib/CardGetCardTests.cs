using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class CardGetCardTests
{
    [Fact]
    public void GetCard_Ariel_Ariel()
    {
        var expected = "On Human Legs";
        var card = Card.GetCard("ARIEL", "On Human Legs");
    }
}
