using System.Xml.XPath;

namespace RPG_Game;

public class Hero : Character
{
    int _level;
    int _xp;
    int _requiredXp;

    public int coins { get; set; }
    //variabler

    Stack<Weapon> equippedWeapon = new(); //stack med heros använda weapon
    public Inventory inventory = new();
    //skapar kompositionen inventory i hero
    Utility utility = new();
    //skapar en kompsition utility för dens funktioner i Hero
    public Hero()
    {
        _hp = 100;
        Weapon weapon = new("Stone-Sword", 10);
        //skapar ett weapon stone sword och ger den värdet 10
        equippedWeapon.Push(weapon);
        //läer in weapon jag skapade i stack equipped weapon
        Name = GetName();
        //får värdet på Name från metoden GetName()
    }
    //konstrukt för hero
    string GetName()
    {
        while (true)
        {
            Console.WriteLine("Hej! Vad vill du heta?");
            string i = Console.ReadLine();
            Console.WriteLine("Vill du heta: " + i + " ? Y/N");
            if (utility.YesAndNo())
            {
                return i;
                //returnerrar i
            }
            //frågar om input och om man är nöjd med valet man gjorde
        }
        //frågara användaren efter namn den vill heta

    }
    //metod för att få namn på spelaren
    public void attack(IDamageable target)
    {
        int i = equippedWeapon.Peek().Damage + (int)(equippedWeapon.Peek().Damage * (0.2 * _level));
        //skadar med weapons damage samt extra per level på hero
        target.Hurt(i);
        //aktiverar targets hurt metod med parametern i
        Console.WriteLine(Name + " skadade med " + i);
        //skriver ut name och skada
    }
    //metod för att skada targets som kan bli skadade
    public void LevelUp(int AmountXp)
    {
        _xp += AmountXp;
        //adderar xp med parametern amountXp
        if (_xp >= _requiredXp)
        {
            _level++;
            //om xp är mer eller lika med _requiredXp blir level plus 1
            Console.WriteLine("LevelUp! Du är " + _level + " Level");
            //skriver ut level
        }
    }
    //metod för Level upp på hero
    public void ChangeWeapon(Weapon weapon)
    {
        equippedWeapon.Push(weapon);
        //lägger in weapon i equippedWeapon
        Console.WriteLine("Du har nu " + weapon.Name);
        //skriver ut vilket weapon man har
    }
    //ändrar ens vapen
    public override void Hurt(int Amount)
    {
        if (_hp <= 0)
        {
            IsDead = true;
            return;
            //om hp är lika med eller mindre än 0 ändrar den till IsDead och returnerar, vilket avslutar metoden
        }
        _hp = (int)(_hp + _hp * (0.2 * _level)) - Amount;
        //gör hp 20% mer per level och tar sedan bort parametern amount
        Console.WriteLine(Name + " har " + _hp + " Hp kvar");
        //skriver ut Name och _hp 
    }
    //metod för att ta skada
    public void Death()
    {
        Console.Clear();
        Console.WriteLine("Du dog");
        Console.WriteLine("tryck enter for att forsätta");
        Console.ReadLine();
    }
    //metod för att skriva ut att hero dog
}
//Skapar klassen Hero från klassen Character
