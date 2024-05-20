namespace RPG_Game;

public class Plains : Map
{
    Queue<Enemy> enemies = new();
    public Plains(string name)
    {
        _name = name;
        for (int i = 0; i < 5; i++)
        {
            Enemy enemy = new(i, 100);
            enemies.Enqueue(enemy);
        }
    }
}
