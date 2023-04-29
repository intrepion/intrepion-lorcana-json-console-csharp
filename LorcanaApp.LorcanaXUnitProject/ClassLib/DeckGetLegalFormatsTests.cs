using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class DeckGetLegalFormatsTests
{
    [Fact]
    public void GetLegalFormats_EmptyDeck_EmptyList()
    {
        var deck = new Deck();
    }
}
