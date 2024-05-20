namespace RPG_Game;

public class Menu
{
    Utility utility = new();
    Town town = new();
    Forrest forrest = new();
    Plains plains = new();
    List<string> _options = new();
    public Menu()
    {
        _options = new List<string>() { town.Name, forrest.Name, plains.Name, "End Game" };
    }

    void ListOptions()
    {
        foreach (var item in _options)
        {
            Console.WriteLine(item);
        }
        //skriver ut alla items från listan _options
    }
    //metod för att skriva ut options
    public void MenuStart()
    {
        Console.WriteLine("Vart vill du gå/göra?");
        Console.WriteLine("Skriv respektiv Nummer");
        ListOptions();
        int i = utility.GetNummber();


    }
    //metod för att starta meny
}
