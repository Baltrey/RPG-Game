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
        _damage = (index + 1) * 2 * 10;//skriver plus ett på index för att det är 0 baserat sen gånger 2 och 10 för att det ska gå upp i värde 
        value = 100 + index * 100;
    }
}
