namespace RPG_Game;

public class Town : Map
{
    List<Weapon> _shopWeapon { get; set; } = new();
    public Town()
    {
        _name = "Town";
        for (int i = 0; i < 5; i++)
        {
            Weapon weapon = new(i);
            //skapar weapon från klassen weapon och lägger in i som index
            _shopWeapon.Add(weapon);
        }
        //skapar 5 weapon och lägger de i listan _shopWeapon
    }
    public void OpenMap(Hero hero)
    {
        OpenMap();
        _active = true;
        Console.ReadLine();
        while (_active)
        {
            ShopOptions(hero);
            _active = Continue();
        }
    }
    void ShopOptions(Hero hero)
    {
        Console.WriteLine("Vill du köpa eller sälja, 1 för köp 2 för sälja");
        int i = utility.GetNummber(1, 2);
        if (i == 1)
        {
            Buy(hero);
        }
        if (i == 2)
        {
            Sell(hero);
        }
    }
    void Sell(Hero hero)
    {
        if (hero.inventory.Items.Count <= 0)
        {
            Console.WriteLine("Du har inga items som går att sälja!");
            return;
        }
        GetSellValue(hero);
        if (utility.YesAndNo())
        {
            Console.WriteLine("Skriv respektivt nummer på item du vill sälja");
            int i = utility.GetNummber(1, hero.inventory.Items.Count);
            //får ett nummer mellan 1 och hero items antal från metoden GetNummber
            i--;//tar i minus ett för 0 baserat indexering
            hero.coins += hero.inventory.Items[i].value;
            //aderar hero coins med items i value från heros inventory
            hero.inventory.Items.RemoveAt(i);
            //tar bort item i från hero inventory

            Console.WriteLine("SÅLD!!!");
            Console.WriteLine("Du har nu " + hero.coins + " coins");
            Console.ReadLine();
        }

    }
    void GetSellValue(Hero hero)
    {

        Console.WriteLine("Jag kan köpa dina items för priset nedan");
        foreach (var item in hero.inventory.Items)
        {
            Console.Write(item.Name + "(" + item.value + ")" + ", ");
        }
        Console.WriteLine("Vill du sälja något Y/N");

    }
    void Buy(Hero hero)
    {
        ListShop();
        Console.WriteLine("Vill du köpa något?Y/N");
        if (utility.YesAndNo())
        {
            Console.WriteLine("Skriv respektiv nummer för att köpa");
            int i = utility.GetNummber(1, _shopWeapon.Count);
            i--;//i minus ett för ett 0 baserat indexering
            if ((hero.coins - _shopWeapon[i].value) >= 0)
            {
                hero.ChangeWeapon(_shopWeapon[i]);
                //om hero coins - shopitem value är mer än 0 så körs changeweapon metoden med shopweapon i
            }
            else
            {
                Console.WriteLine("Tyvärr för få coins för att köpa detta item");
            }
        }
    }
    void ListShop()
    {
        Console.WriteLine("I Shopen finns: ");
        foreach (var item in _shopWeapon)
        {
            Console.Write(item.Name + "(" + item.value + ")" + ", ");
        }
        Console.WriteLine("");
    }
}
