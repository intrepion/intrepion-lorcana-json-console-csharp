namespace LorcanaApp.LorcanaClassLibProject;

public class Card
{
    public static Card MickeyMouseWaywardSorcerer { get; } = new Card();

    public static List<int> AllCards { get; } = new List<int>{
        0,
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        12,
        13,
        14,
        15,
        16,
        17,
        18,
        19,
        20,
        21,
        22,
        23,
        24,
        25,
        26,
        27,
        28,
        29,
        30,
        31,
        32,
        33,
        34,
    };

    public bool IsLegal()
    {
        return true;
    }
}
