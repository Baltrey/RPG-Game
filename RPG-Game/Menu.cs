namespace RPG_Game;

public class Menu
{
    Utility utility = new();
    Town town = new();
    Forrest forrest = new();
    Plains plains = new();
    List<string> _options = new();
    bool _gameActive;
    public Menu()
    {
        _options = new List<string>() { town.Name + " (1)", forrest.Name + " (2)", plains.Name + " (3)", "Exit Game (4)" };
        _gameActive = true;
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
    public void MenuStart(Hero hero)
    {
        while (_gameActive)
        {
            Console.Clear();
            Console.WriteLine("Vart vill du gå/göra?");
            Console.WriteLine("Skriv respektiv Nummer");
            ListOptions();
            GetOption(hero);


        }


    }
    //metod för att starta meny
    void GetOption(Hero hero)
    {
        int i = utility.GetNummber(1, 4);
        if (i == 1)
        {
            town.OpenMap(hero);
        }
        if (i == 2)
        {
            forrest.OpenMap(hero);
        }
        if (i == 3)
        {
            plains.OpenMap(hero);
        }
        if (i == 4)
        {
            _gameActive = false;
        }
    }
}
