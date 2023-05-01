namespace LorcanaApp.LorcanaClassLibProject;

public class Card
{
    public static Card MickeyMouseWaywardSorcerer { get; } = new Card();

    public bool IsLegal()
    {
        return true;
    }
}
