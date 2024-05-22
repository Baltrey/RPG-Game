namespace RPG_Game;

public class Plains : Map
{
    Queue<Enemy> enemies = new();
    public Plains()
    {
        _name = "Plains";
        for (int i = 0; i < 20; i++)
        {
            Enemy enemy = new(i);
            //skapar enemy med difficoulty i
            enemies.Enqueue(enemy);
            //lägger till enemy
        }
        //vid instans skapar den 20 enemies i listan enemies samt ger sig själv namnen plains.
    }
    public void OpenMap(Hero hero)
    {
        OpenMap();
        while (_active)
        {
            Encounter(hero);
            if (_active)
            {
                _active = Continue();
            }
        }
        Console.ReadLine();
    }
    public void Encounter(Hero hero)
    {
        Console.WriteLine(enemies.Peek().Name + " Dyker upp!!!");

        while (!enemies.Peek().IsDead && !hero.IsDead)
        {
            enemies.Peek().attack(hero);
            hero.attack(enemies.Peek());
            Thread.Sleep(100);
        }
        if (enemies.Peek().IsDead)
        {
            hero.LevelUp(enemies.Peek().Death());
            enemies.Dequeue();
        }
        if (hero.IsDead)
        {
            _active = false;
            hero.Death();
        }
    }
}
