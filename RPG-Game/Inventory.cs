namespace RPG_Game;

public class Inventory
{
    public List<Item> Items { get; set; } = new();
    //skapar listan items med item i

    int _space = 10;
    public void ListInventory()
    {
        Console.WriteLine("Du Har: ");
        foreach (var item in Items)
        {
            Console.Write(item.Name + ", ");
            //skriver ut item Name
        }
        //kör för varje item i lista Items
        Console.WriteLine("I ditt Inventory");
        Console.WriteLine("Inventory har " + _space + " kvar");
        Console.ReadLine();
        //skriver ut hur mycket space inventory har kvar
    }
    //metod för att skriva ut alla items i inventory
    public void AddItems(Item item)
    {
        if ((_space - item.Space) > 0)
        {
            _space -= item.Space;
            //tar bort från inventorys space med items space värde
            Items.Add(item);
            //lägger till parametern item i listan items
            ListInventory();
            //kör metoden listInventory
        }
        //om inventory har space kvar lägger den till item
        else
        {
            Console.WriteLine("Ditt inventory är fullt");
        }
        //annars skriver det ut att ditt inventory är fullt
    }
    //metod för att lägga till item i inventory, tar in parametern item som ska läggas till
    public void RemoveItems(int index)
    {
        _space += Items[index].Space;
        //ger tillbaka itemets space till inventory
        Items.RemoveAt(index);
        //tar bort item från listan items med angivna index
        ListInventory();
        //kör metoden för att skriva ut alla items
    }
    //metod för att ta bort items ur inventory, tar in parametern int index
}
