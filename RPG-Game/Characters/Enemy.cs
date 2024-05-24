using System.Reflection.Metadata.Ecma335;

namespace RPG_Game;

public class Enemy : Character
{
    int _xpDrop = Random.Shared.Next(100, 200);
    int _difficulty;
    int _damage;
    //variabler

    public Enemy(int difficulty)
    {
        string[] Names = { "Goblin", "Skeleton", "Zombie", "Ghost" };//array med namn för monster
        int i = Random.Shared.Next(Names.Length);
        //ger i ett random värde med max värdet av names längd
        Name = Names[i];
        //ger enemy ett random namn efter listan namn
        _difficulty = difficulty;//ger _difficulty värde efter parametern difficulty
        _hp = 100;
    }
    //konstrukt för klassen enemy, tar in parametern difficulty vid skapelse
    public int Death()
    {
        if (IsDead)
        {
            return _xpDrop;
            //om död returnerar den _xpdrop
        }
        else
        {
            return 0;
        }
    }
    //metod för att få xp vid death
    public void attack(IDamageable target)
    {
        _damage = Random.Shared.Next(10, 20);
        //ger _damage ett random värde mellan 10 och 20
        int i = (_damage + (int)(_damage * (0.2 * _difficulty)));
        //gör enemys 20% svårare per difficulty, skadar 20% mer
        target.Hurt(i);
        //startar targets hurt metod med parametern i som är totala damage
        Console.WriteLine(Name + " skadade dig med " + _damage);
        //skriver ut skada och namn på den som skaded
    }
    //metod för att skada targets som kan bli skadade
    public override void Hurt(int Amount)
    {
        if (_hp <= 0)
        {
            IsDead = true;
            return;
        }
        //om hp är mindre eller lika med 0 returnerar den och ändrar värde på isdead till true
        _hp = (int)(_hp + _hp * (0.2 * _difficulty)) - Amount;
        //gör hp 20% mer sen tar det minus parametern amount
        Console.WriteLine(Name + " har " + _hp + " Hp kvar");
        //skriver ut hur mycket hp enemy har
    }
    //metod för att ta skada
}
