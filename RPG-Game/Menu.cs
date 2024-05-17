namespace RPG_Game;

public class Menu
{
    Utility utility = new();
    string[] _options = { "Town", "Forrest", "Plains", "End Game" };
    void ListOptions()
    {
        foreach (var item in _options)
        {
            Console.WriteLine(item);
        }
        //skriver ut alla items från listan _options
    }
    //metod för att skriva ut options
    public void MenuStart(){
        Console.WriteLine("Vart vill du gå/göra?");
        ListOptions();
        int i = utility.GetNummber();


    }
    //metod för att starta meny
}
