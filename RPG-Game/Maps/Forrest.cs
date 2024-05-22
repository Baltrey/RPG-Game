namespace RPG_Game;

public class Forrest : Map
{
    public List<Item> Items { get; set; } = new();
    public Forrest()
    {
        _name = "Forrest";

        for (int i = 0; i < 10; i++)
        {
            ForrestItems item = new();
            Items.Add(item);
            //lägger till item i items listan
        }
        //skapar 10 forrest items och lägger till det i listan items

    }
    public void OpenMap(Hero hero)
    {
        while (_active)
        {
            OpenMap();
            Console.ReadLine();
            Console.Clear();
            PickupItem(hero);
        }

    }
    void ListItems()
    {
        Console.WriteLine("Det finns: ");
        foreach (var item in Items)
        {
            Console.Write(item.Name + ", ");
        }
    }
    void PickupItem(Hero hero)
    {
        Console.WriteLine("skriv vilket item du vill ha(deras index)");
        ListItems();
        int i = (utility.GetNummber(1, Items.Count) - 1);
        hero.inventory.AddItems(Items[i]);
        Items.RemoveAt(i);
    }
}
