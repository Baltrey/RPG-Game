namespace RPG_Game;

public class Menu
{
    Utility utility = new();
    Town town = new();
    Forrest forrest = new();
    Plains plains = new();
    //skapar 3 mapar och en utility
    List<string> _options = new();
    bool _gameActive;
    //skapar variabeln game active
    public Menu()
    {
        _options = new List<string>() { town.Name + " (1)", forrest.Name + " (2)", plains.Name + " (3)", "Exit Game (4)" };
        _gameActive = true;
        //lägger till options i listan opion och ändrar värde på gameactive till true
    }
    //konstruktor för vid instans av menu

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
            //kör metoden för att få ut alla options
            GetOption(hero);
            //kör metoden för att få spelarens input till vilken option som ska göras
        }
        //körs medans game active


    }
    //metod för att starta meny
    void GetOption(Hero hero)
    {
        int i = utility.GetNummber(1, 4);
        if (i == 1)
        {
            town.OpenMap(hero);
            //om 1 körs town open map metod med hero som input
        }
        if (i == 2)
        {
            forrest.OpenMap(hero);
            //om 2 körs forrest openmap metod med hero som input
        }
        if (i == 3)
        {
            plains.OpenMap(hero);
            //om 3 körs planis openmap metod med hero som input
        }
        if (i == 4)
        {
            _gameActive = false;
            //om 4 ändras _gameActive till false och spelet slutar
        }
    }
    //metod för att få ut spelarens input till vilken option som ska köras
}
