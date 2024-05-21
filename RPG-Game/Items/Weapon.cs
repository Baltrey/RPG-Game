namespace RPG_Game;

public class Weapon : Item
{
    int _damage;
    public int Damage { get { return _damage; } }
    public Weapon(string name, int damage)
    {
        Name = name;
        _damage = damage;
    }
}
