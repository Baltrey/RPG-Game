namespace RPG_Game;

public class Weapon : Item
{
    int _damage;
    public int Damage { get { return _damage; } }
    //variabler för damage
    string[] WeaponNames = { "Järnsvärd", "Stålsvärd", "Silversvärd", "Draksvärd", "Eldsvärd" };//Namn weapon kan ha
    public Weapon(string name, int damage)
    {
        Name = name;
        _damage = damage;
        //ändrar name och damage efter parametrarna
    }
    //konstrukt för weapon tar in name och damage i parametern
    public Weapon(int index)
    {
        Name = WeaponNames[index];
        //ger namn på wapon efter listan med möjliga namn och parametern index
        _damage = (index + 1) * 2 * 10;//skriver plus ett på index för att det är 0 baserat sen gånger 2 och 10 för att det ska gå upp i värde 
        value = 100 + index * 100;
        //ger värde på value efter index med bas 100
    }
    //konstrukt Weapon tar in parameter index
}
