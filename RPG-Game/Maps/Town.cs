namespace RPG_Game;

public class Town : Map
{
    public Town()
    {
        _name = "Town";
    }
    public void OpenMap(Hero hero)
    {
        OpenMap();
        Console.ReadLine();
        while (_active)
        {

        }
    }
    void OpenShop(Hero hero)
    {
        Console.WriteLine("Hej välkommen till shopen");


    }
}
