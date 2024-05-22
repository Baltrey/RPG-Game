namespace RPG_Game;

public class Weapon : Item
{
    int _damage;
    public int Damage { get { return _damage; } }
    string[] WeaponNames = { "Järnsvärd", "Stålsvärd", "Silversvärd", "Draksvärd", "Eldsvärd" };
    public Weapon(string name, int damage)
    {
        Name = name;
        _damage = damage;
    }
    public Weapon(int index)
    {
        Name = WeaponNames[index];
        _damage = index * 2 * 10;
        value = 100 + index * 100;
    }
}
