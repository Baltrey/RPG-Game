namespace RPG_Game;

public class Forrest : Map
{
    public Forrest(string name)
    {
        _name = name;
    }
    public override void OpenMap()
    {
        Console.WriteLine("Hej!!!");
        base.OpenMap();
    }
}
