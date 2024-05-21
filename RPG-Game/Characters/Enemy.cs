using System.Reflection.Metadata.Ecma335;

namespace RPG_Game;

public class Enemy : Character
{
    int _xpDrop = Random.Shared.Next(100, 200);
    int _difficulty;
    int _damage = Random.Shared.Next(10, 20);

    public int Hp
    {
        get
        {
            float i = ((float)(_hp * (1.2 * _difficulty)));
            //gör enemys 20% svårare per difficulty
            return (int)i;
        }
        set
        {
            if ((_hp - value) > 0)
            {
                _hp -= value;
            }
            else
            {
                IsDead = true;
            }
        }
    }
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
        float i = ((float)(_damage * (1.2 * _difficulty)));
        //gör enemys 20% svårare per difficulty, skadar 20% mer
        target.Hurt((int)i);
        Console.WriteLine(Name + " skadade dig med " + _damage);
    }
    //metod för att skada targets som kan bli skadade
    public override void Hurt(int Amount)
    {
        Hp -= Amount;
        //gör att enemy får 20% mer hp per difficulty
    }
}
