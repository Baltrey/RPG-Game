using System.Xml.XPath;

namespace RPG_Game;

public class Hero : Character
{
    int _level = 1;
    int _xp;
    int _requiredXp;

    Utility utility = new();
    //skapar en kompsition utility för dens funktioner i Hero
    public Hero()
    {
        Hp = 100;
        while (true){
            Console.WriteLine("Hej! Vad vill du heta?");
            string i = Console.ReadLine();
            Console.WriteLine("Vill du heta: " + i + " ? Y/N");
            if(utility.YesAndNo()){
                Name = i;
                return;
            }
            //frågar om input och om man är nöjd med valet man gjorde
        }
        //frågara användaren efter namn den vill heta

    }
    public void attack(IDamageable target, int Amount) {
        target.Hurt(Amount);
    }
    //metod för att skada targets som kan bli skadade
    public void LevelUp(int AmountXp){
        _xp += AmountXp;
        if (_xp >= _requiredXp) {
            _level ++;
            Console.WriteLine("LevelUp! Du är " + _level+ " Level");
        }
    }
}
//Skapar klassen Hero från klassen Character
