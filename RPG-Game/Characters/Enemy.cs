using System.Reflection.Metadata.Ecma335;

namespace RPG_Game;

public class Enemy : Character
{
    int _xpDrop = Random.Shared.Next(100, 200);
    int _difficulty;
    int _damage;

    public Enemy(int difficulty)
    {
        string[] Names = { "Goblin", "Skeleton", "Zombie", "Ghost" };
        int i = Random.Shared.Next(Names.Length);
        Name = Names[i];
        _difficulty = difficulty;
        _hp = 100;
    }
    public int Death()
    {
        if (IsDead)
        {
            return _xpDrop;
        }
        else
        {
            return 0;
        }
    }
    public void attack(IDamageable target)
    {
        _damage = Random.Shared.Next(10, 20);
        int i = (_damage + (int)(_damage * (0.2 * _difficulty)));
        //gör enemys 20% svårare per difficulty, skadar 20% mer
        target.Hurt(i);
        Console.WriteLine(Name + " skadade dig med " + _damage);
    }
    //metod för att skada targets som kan bli skadade
    public override void Hurt(int Amount)
    {
        if (_hp <= 0)
        {
            IsDead = true;
            return;
        }
        _hp = (int)(_hp + _hp * (0.2 * _difficulty)) - Amount;
        Console.WriteLine(Name + " har " + _hp + " Hp kvar");
    }
    //metod för att ta skada
}
