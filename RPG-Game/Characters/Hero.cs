using System.Xml.XPath;

namespace RPG_Game;

public class Hero : Character
{
    int _level;
    int _xp;
    int _requiredXp;

    Stack<Weapon> equippedWeapon = new();
    Inventory inventory = new();
    //skapar kompositionen inventory i hero
    Utility utility = new();
    //skapar en kompsition utility för dens funktioner i Hero
    public Hero()
    {
        _hp = 100;
        Weapon weapon = new("Stone-Sword", 10);
        equippedWeapon.Push(weapon);
        while (true)
        {
            Console.WriteLine("Hej! Vad vill du heta?");
            string i = Console.ReadLine();
            Console.WriteLine("Vill du heta: " + i + " ? Y/N");
            if (utility.YesAndNo())
            {
                Name = i;
                return;
            }
            //frågar om input och om man är nöjd med valet man gjorde
        }
        //frågara användaren efter namn den vill heta

    }
    public void attack(IDamageable target)
    {
        int i = (int)(equippedWeapon.Peek().Damage * (1.2 * _level));
        //skadar med weapons damage samt extra per level på hero
        target.Hurt(i);
        Console.WriteLine("Du skadade med " + i);
    }
    //metod för att skada targets som kan bli skadade
    public void LevelUp(int AmountXp)
    {
        _xp += AmountXp;
        if (_xp >= _requiredXp)
        {
            _level++;
            Console.WriteLine("LevelUp! Du är " + _level + " Level");

        }
    }
    public void ChangeWeapon(Weapon weapon)
    {
        equippedWeapon.Push(weapon);
    }
    public override void Hurt(int Amount)
    {
        _hp = (int)(_hp * (1.2 * _level)) - Amount;
    }
    public void Death()
    {
        Console.Clear();
        Console.WriteLine("Du dog");
        Console.WriteLine("tryck enter for att forsätta");
        Console.ReadLine();
    }
}
//Skapar klassen Hero från klassen Character
