using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class CardGetCardTests
{
    [Fact]
    public void GetCard_ArielOnHumanLegs_NotNull()
    {
        var actual = Card.GetCard("ARIEL", "On Human Legs");

        Assert.NotNull(actual);
    }
}
