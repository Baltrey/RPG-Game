namespace RPG_Game;

public class Town : Map
{
    List<Weapon> _shopWeapon { get; set; } = new();
    //skapar en lista med weapon i shop
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
        //kör basklassens openmap metod
        _active = true;
        Console.ReadLine();
        while (_active)
        {
            ShopOptions(hero);
            //kör metoden med hero som input
            _active = Continue();
            //ändrar värdet på aktive utifrån metoden continue
        }
        //kör medans active
    }
    void ShopOptions(Hero hero)
    {
        Console.WriteLine("Vill du köpa eller sälja, 1 för köp 2 för sälja");
        int i = utility.GetNummber(1, 2);
        //får ett nummer från spelaren via utility getnummber metod, och ger att det måste vara mellan 1 och 2
        if (i == 1)
        {
            Buy(hero);
        }
        // om 1 körs Buy metoden med hero som input
        if (i == 2)
        {
            Sell(hero);
        }
        //om 2 körs sell metoden med hero som input
    }
    //metod för att få options man kan göra
    void Sell(Hero hero)
    {
        if (hero.inventory.Items.Count <= 0)
        {
            Console.WriteLine("Du har inga items som går att sälja!");
            return;
        }
        //om det inte finns items i heros inventory returnerar den och säger att du har inga items som går att sälja
        GetSellValue(hero);
        //kör metoden för att få värde på alla items
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
        //frågar spelarene om den vill sälja utifrån utilitys YesAndNo metod
    }
    //metod för att sälja items
    void GetSellValue(Hero hero)
    {

        Console.WriteLine("Jag kan köpa dina items för priset nedan");
        foreach (var item in hero.inventory.Items)
        {
            Console.Write(item.Name + "(" + item.value + ")" + ", ");
            //skriver ut items name plus värde på den
        }
        //kör för varje item i heros inventory
        Console.WriteLine("Vill du sälja något Y/N");

    }
    //metod för att få sälj värdet på alla items
    void Buy(Hero hero)
    {
        ListShop();
        //kör metoden ListShop som skriver ut alla items i shopen
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
        //frågar om spelaren vill köra något
    }
    //metod för att köpa items
    void ListShop()
    {
        Console.WriteLine("I Shopen finns: ");
        foreach (var item in _shopWeapon)
        {
            Console.Write(item.Name + "(" + item.value + ")" + ", ");
            //skriver ut namn och value
        }
        //kör för varje item i listan shopweapon
        Console.WriteLine("");
    }
    //metod för att skriva ut alla items i shopen
}
