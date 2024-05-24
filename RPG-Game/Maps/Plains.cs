namespace RPG_Game;

public class Plains : Map
{
    Queue<Enemy> enemies = new();
    //skapar en queue med enemy
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
    //konstruktor för plains
    public void OpenMap(Hero hero)
    {
        OpenMap();
        //kör metoden OpenMap som ger namn på mappen
        while (_active)
        {
            Encounter(hero);
            //startar metoden encounter med parametern hero
            if (_active)
            {
                _active = Continue();
            }
            //om fortfaraned active så kör continue metoden och ändrar värde på den

        }
        //kör medans active
        Console.ReadLine();
    }
    public void Encounter(Hero hero)
    {
        Console.WriteLine(enemies.Peek().Name + " Dyker upp!!!");
        //skriver ut enemys name som kommer attakera

        while (!enemies.Peek().IsDead && !hero.IsDead)
        {
            enemies.Peek().attack(hero);
            //kör enemy som är först i queue attack metod mot hero som target
            hero.attack(enemies.Peek());
            //kör heros attackmetod med första i queuen enemy som target
            Thread.Sleep(500);
        }
        //kör medans enemy eller hero inte är död
        if (enemies.Peek().IsDead)
        {
            hero.LevelUp(enemies.Peek().Death());
            enemies.Dequeue();
        }
        //om enemy är död körs hero levelup och enemy death metod
        if (hero.IsDead)
        {
            _active = false;
            hero.Death();
        }
        //om hero dör körs dens death metod och plains tar slut
    }
    //metod för gamplay i plains
}
