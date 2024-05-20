using System.Reflection.Metadata.Ecma335;

namespace RPG_Game;

public class Enemy : Character
{
    int _xpDrop = Random.Shared.Next(10, 200);
    int _difficulty;
    int _damage = Random.Shared.Next(10, 20);
    public int Damage
    {
        get
        {
            float i = ((float)(_damage * (0.2 * _difficulty)));
            //gör enemys 20% svårare per difficulty
            return (int)i;
        }
        set { }
    }
    public bool IsDead { get; set; } = false;
    public int Hp
    {
        get
        {
            float i = ((float)(_hp * (0.2 * _difficulty)));
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
    public Enemy(int difficulty, int baseHp)
    {
        string[] Names = { "Goblin", "Skeleton", "Zombie", "Ghost" };
        int i = Random.Shared.Next(Names.Length);
        Name = Names[i];
        _difficulty = difficulty;
        _hp = baseHp;
    }
}
