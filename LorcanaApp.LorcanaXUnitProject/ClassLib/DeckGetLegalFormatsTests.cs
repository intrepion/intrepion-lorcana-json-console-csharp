using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class DeckGetLegalFormatsTests
{
    [Fact]
    public void GetLegalFormats_EmptyDeck_EmptyList()
    {
        var expected = 0;
        var deck = new Deck();

        var formats = deck.GetLegalFormats();
        var actual = formats.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLegalFormats_DeckDemo_FormatDemo()
    {
        var expected = 1;
        var deck = new Deck();

        deck.AddCard(Card.GetCard("GOONS", "Maleficent’s Underlings"));
        deck.AddCard(Card.GetCard("GOONS", "Maleficent’s Underlings"));
        deck.AddCard(Card.GetCard("FLOUNDER", "Voice of Reason"));
        deck.AddCard(Card.GetCard("FLOUNDER", "Voice of Reason"));
        deck.AddCard(Card.GetCard("CAPTAIN HOOK", "Forceful Duelist"));
        deck.AddCard(Card.GetCard("CAPTAIN HOOK", "Forceful Duelist"));
        deck.AddCard(Card.GetCard("CAPTAIN HOOK", "Forceful Duelist"));
        deck.AddCard(Card.GetCard("AURORA", "Regal Princess"));
        deck.AddCard(Card.GetCard("AURORA", "Regal Princess"));
        deck.AddCard(Card.GetCard("AURORA", "Regal Princess"));
        deck.AddCard(Card.GetCard("PRINCE ERIC", "Dashing and Brave"));
        deck.AddCard(Card.GetCard("PRINCE ERIC", "Dashing and Brave"));
        deck.AddCard(Card.GetCard("KRISTOFF", "Official Ice Master"));
        deck.AddCard(Card.GetCard("KRISTOFF", "Official Ice Master"));
        deck.AddCard(Card.GetCard("JASMINE", "Disguised"));
        deck.AddCard(Card.GetCard("JASMINE", "Disguised"));
        deck.AddCard(Card.GetCard("AURORA", "Briar Rose"));
        deck.AddCard(Card.GetCard("AURORA", "Briar Rose"));
        deck.AddCard(Card.GetCard("AURORA", "Briar Rose"));
        deck.AddCard(Card.GetCard("MALEFICENT", "Sinister Visitor"));
        deck.AddCard(Card.GetCard("MALEFICENT", "Sinister Visitor"));
        deck.AddCard(Card.GetCard("MALEFICENT", "Sinister Visitor"));
        deck.AddCard(Card.GetCard("AURORA", "Dreaming Guardian	1"));
        deck.AddCard(Card.GetCard("BEAST", "Hardheaded"));
        deck.AddCard(Card.GetCard("BEAST", "Hardheaded"));
        deck.AddCard(Card.GetCard("SCAR", "Mastermind"));
        deck.AddCard(Card.GetCard("DEVELOP YOUR BRAIN", null));
        deck.AddCard(Card.GetCard("DEVELOP YOUR BRAIN", null));
        deck.AddCard(Card.GetCard("DEVELOP YOUR BRAIN", null));
        deck.AddCard(Card.GetCard("FIRE THE CANNONS!", null));
        deck.AddCard(Card.GetCard("FIRE THE CANNONS!", null));
        deck.AddCard(Card.GetCard("ONE JUMP AHEAD", null));
        deck.AddCard(Card.GetCard("ONE JUMP AHEAD", null));
        deck.AddCard(Card.GetCard("SMASH", null));
        deck.AddCard(Card.GetCard("SMASH", null));
        deck.AddCard(Card.GetCard("FRYING PAN", null));
        deck.AddCard(Card.GetCard("FRYING PAN", null));

        var formats = deck.GetLegalFormats();
        var actual = formats.Count;

        Assert.Equal(expected, actual);
    }
}
