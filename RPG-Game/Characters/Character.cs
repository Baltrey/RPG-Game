namespace RPG_Game;

public abstract class Character : IDamageable
{
    public string Name { get; set; }
    public bool IsDead { get; set; } = false;
    protected int _hp;
    public virtual void Hurt(int Amount)
    {
        _hp -= Amount;
    }
}
//skapar klassen Character från interface IDamageable