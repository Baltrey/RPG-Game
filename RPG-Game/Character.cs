namespace RPG_Game;

public abstract class Character : IDamageable
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public void Hurt(int Amount)
    {
        Hp -= Amount;
    }
}
//skapar klassen Character från interface IDamageable