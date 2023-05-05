using LorcanaApp.LorcanaClassLibProject;

namespace LorcanaApp.LorcanaXUnitProject.ClassLib;

public class CardIsLegalTests
{
    private Card _action { get; set; }
    private Card _character { get; set; }
    private Card _item { get; set; }
    private Card _song { get; set; }

    public CardIsLegalTests()
    {
        _action = new Card
        {
            Classifications = new List<Classification>
            {
                Classification.Action,
            },
            Cost = 1,
            InkwellIcon = true,
            Name = "CONTROL YOUR TEMPER",
            Type = CardType.Action,
        };

        _character = new Card
        {
            Classifications = new List<Classification>
            {
                Classification.Hero,
                Classification.Princess,
                Classification.Storyborn,
            },
            Cost = 4,
            InkwellIcon = true,
            LoreValue = 2,
            Name = "ARIEL",
            Strength = 3,
            Type = CardType.Character,
            Version = "On Human Legs",
            Willpower = 4,
        };

        _item = new Card
        {
            Classifications = new List<Classification>
            {
                Classification.Item,
            },
            Cost = 1,
            InkwellIcon = true,
            Name = "DINGLEHOPPER",
            Type = CardType.Item,
        };

        _song = new Card
        {
            Classifications = new List<Classification>
            {
                Classification.Action,
                Classification.Song,
            },
            Cost = 2,
            InkwellIcon = false,
            Name = "ONE JUMP AHEAD",
            Type = CardType.Song,
        };
    }

    [Fact]
    public void IsLegal_CardEmpty_False()
    {
        var emptyCard = new Card();

        var actual = emptyCard.IsLegal();

        Assert.False(actual);
    }


    [Fact]
    public void IsLegal_CardFull_True()
    {
        var actual = _character.IsLegal();

        Assert.True(actual);
    }

    [Fact]
    public void IsLegal_ClassificationsEmpty_False()
    {
        _character.Classifications = new List<Classification>();

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_ClassificationsNull_False()
    {
        _character.Classifications = null;

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_CostNull_False()
    {
        _character.Cost = null;

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_InkNull_False()
    {
        _character.Ink = null;
    }

    [Fact]
    public void IsLegal_InkwellIconNull_False()
    {
        _character.InkwellIcon = null;

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_NameEmpty_False()
    {
        _character.Name = "";

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_NameNull_False()
    {
        _character.Name = null;

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_NameNotUppercase_False()
    {
        _character.Name = "Ariel";

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_NameWhitespace_False()
    {
        _character.Name = " ";

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeActionClassificiationNoAction_False()
    {
        _action.Classifications = new List<Classification>
        {
            Classification.Item,
        };

        var actual = _action.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterLoreValueNull_False()
    {
        _character.LoreValue = null;

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterStrengthNull_False()
    {
        _character.Strength = null;

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterVersionEmpty_False()
    {
        _character.Version = "";

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterVersionNull_False()
    {
        _character.Version = null;

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterVersionWhitespace_False()
    {
        _character.Version = " ";

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeCharacterWillpowerNull_False()
    {
        _character.Willpower = null;

        var actual = _character.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeItemClassificationNoItem_False()
    {
        _item.Classifications = new List<Classification>
        {
            Classification.Action,
        };

        var actual = _item.IsLegal();

        Assert.False(actual);
    }


    [Fact]
    public void IsLegal_TypeSongClassificationNoAction_False()
    {
        _song.Classifications = new List<Classification>
        {
            Classification.Song,
        };

        var actual = _song.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeSongClassificationNoSong_False()
    {
        _song.Classifications = new List<Classification>
        {
            Classification.Action,
        };

        var actual = _song.IsLegal();

        Assert.False(actual);
    }

    [Fact]
    public void IsLegal_TypeNull_False()
    {
        _character.Type = null;

        var actual = _character.IsLegal();

        Assert.False(actual);
    }
}
