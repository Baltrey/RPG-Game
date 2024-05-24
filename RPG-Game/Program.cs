using System.Reflection.Metadata.Ecma335;
using RPG_Game;

Menu menu = new();
Hero hero = new();
//skapar menu och hero

Console.WriteLine("Hej välkommen till min fantastiska RPG_Game");
Console.ReadLine();
menu.MenuStart(hero);
//kör menus menustar metod
