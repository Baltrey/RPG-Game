namespace RPG_Game;

public abstract class Map
{
    protected string _name;
    public virtual void OpenMap()
    {
        Console.WriteLine("Hej välkommen till " + _name);
    }
}
