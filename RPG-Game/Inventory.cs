namespace RPG_Game;

public class Inventory
{
    public List<Item> Items { get; set; } = new();

    int _space = 10;
    public void ListInventory()
    {
        Console.WriteLine("Du Har: ");
        foreach (var item in Items)
        {
            Console.Write(item.Name + ", ");
        }
        Console.WriteLine("I ditt Inventory");
    }
    public void AddItems(Item item)
    {
        if ((_space - item.Space) > 0)
        {
            _space -= item.Space;
            Items.Add(item);
            ListInventory();
        }
        else
        {
            Console.WriteLine("Ditt inventory är fullt");
        }
    }
    public void RemoveItems(int index)
    {
        _space += Items[index].Space;
        Items.RemoveAt(index);
        ListInventory();
    }
}
