namespace RPG_Game;

public class Inventory
{
    public List<Item> Items { get; set; } = new();

    public void ListInventory()
    {
        Console.WriteLine("Du Har: ");
        foreach (var item in Items)
        {
            Console.Write(Items + ", ");
        }
        Console.WriteLine("I ditt Inventory");
    }
    public void GetItems(Item item)
    {
        Items.Add(item);
        ListInventory();
    }
    public void RemoveItems(int index)
    {
        Items.RemoveAt(index);
        ListInventory();
    }
}
