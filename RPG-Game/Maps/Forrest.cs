namespace RPG_Game;

public class Forrest : Map
{
    public Forrest()
    {
        _name = "Forrest";
    }
    public override void OpenMap()
    {
        Console.WriteLine("Hej!!!");
        base.OpenMap();
    }
}
