namespace RPG_Game;

public abstract class Character : IDamageable
{
    public string Name { get; set; }
    public bool IsDead { get; set; } = false;
    protected int _hp;
    //variebler
    public virtual void Hurt(int Amount)
    {
        _hp -= Amount;
    }
    //metod för att ta damage
}
//skapar klassen Character från interface IDamageable