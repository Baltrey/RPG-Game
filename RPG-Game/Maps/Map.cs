namespace RPG_Game;

public abstract class Map
{
    Utility utility = new();
    protected string _name;
    public string Name
    {
        get { return _name; }
    }
    protected bool _active;
    public virtual void OpenMap()
    {
        Console.WriteLine("Hej välkommen till " + _name);
    }
    protected bool Continue()
    {
        Console.WriteLine("Vill du forsätta att vara i " + _name + " Y/N");
        return utility.YesAndNo();
    }
}
