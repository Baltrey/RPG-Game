namespace RPG_Game;

public abstract class Character : IDamageable
{
    public Inventory Inventory { get; set; } = new();
    public string Name { get; set; }
    protected int _hp;
    public void Hurt(int Amount)
    {
        _hp -= Amount;
    }
}
//skapar klassen Character från interface IDamageable