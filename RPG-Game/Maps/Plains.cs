namespace RPG_Game;

public class Plains : Map
{
    Queue<Enemy> enemies = new();
    public Plains()
    {
        _name = "Plains";
        for (int i = 0; i < 5; i++)
        {
            Enemy enemy = new(i, 100);
            enemies.Enqueue(enemy);
        }
    }
    public void OpenMap(Hero hero)
    {
        base.OpenMap();
        while (_active)
        {
            Encounter(hero);
            _active = Continue();
        }
    }
    void Encounter(Hero hero)
    {
        Console.WriteLine(enemies.Peek().Name + " Dyker upp!!!");
        while (!enemies.Peek().IsDead)
        {

        }
    }
}
