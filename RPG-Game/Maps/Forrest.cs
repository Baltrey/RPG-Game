namespace RPG_Game;

public class Forrest : Map
{
    public List<Item> Items { get; set; } = new();
    public Forrest()
    {
        _name = "Forrest";
        CreateItems();

    }
    public void OpenMap(Hero hero)
    {
        OpenMap();
        Console.ReadLine();
        while (_active)
        {
            Console.Clear();
            PickupItem(hero);
            _active = Continue();
        }

    }
    void ListItems()
    {
        Console.WriteLine("Det finns: ");
        foreach (var item in Items)
        {
            Console.Write(item.Name + ", ");
        }
        Console.WriteLine("");
    }
    //metod för att skriva alla items
    void PickupItem(Hero hero)
    {
        if (Items.Count == 0)
        {
            CreateItems();
        }
        //om listan items är tom skapar den nya
        Console.WriteLine("skriv vilket item du vill ha(deras index)");
        ListItems();
        int i = (utility.GetNummber(1, Items.Count) - 1);
        //får ett index i från metoden getnummber
        hero.inventory.AddItems(Items[i]);
        //lägger till Item med index i heros inventory
        Items.RemoveAt(i);
        //tar bort index i från listan Items
    }
    //metod för att ta upp items
    void CreateItems()
    {
        for (int i = 0; i < 20; i++)
        {
            ForrestItems item = new();
            Items.Add(item);
            //lägger till item i items listan
        }
        //skapar 10 forrest items och lägger till det i listan items
    }
}
