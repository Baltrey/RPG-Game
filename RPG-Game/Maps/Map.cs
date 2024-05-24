namespace RPG_Game;

public abstract class Map
{
    protected Utility utility = new();
    //skapar en protected utility i Map
    protected string _name;
    public string Name
    {
        get { return _name; }
    }
    protected bool _active = true;
    public void OpenMap()
    {
        Console.Clear();
        Console.WriteLine("Hej välkommen till " + _name);
    }
    //metod för att öppna mappen, skriver ut namn på den
    protected bool Continue()
    {
        Console.WriteLine("Vill du forsätta att vara i " + _name + " Y/N");
        return utility.YesAndNo();
        //får en bool av utility YesAndNo och returnerar den 
    }
    //frågar spelaren om den vill fortsätta var i angivna mapen
}
