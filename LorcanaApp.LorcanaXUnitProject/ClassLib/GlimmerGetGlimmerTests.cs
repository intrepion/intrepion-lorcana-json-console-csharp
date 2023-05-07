using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class GlimmerGetGlimmerTests
{
    [Fact]
    public void GetGlimmer_ArielOnHumanLegs_NotNull()
    {
        var actual = Glimmer.GetGlimmer("ARIEL", "On Human Legs");

        Assert.NotNull(actual);
    }
}
