﻿using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace RPG_Game;

public class Utility
{
    public int GetNummber()
    {
        string? i = "";

        int j;
        while (!int.TryParse(i, out j) == true)
        {
            i = Console.ReadLine();
            if ((!int.TryParse(i, out j) == true))
            {
                Console.WriteLine("SKRIV ETT NUMMER!!!!");

            }
            //kollar att det är ett nummer, om inte ger användaren instruktioner att det är fel
        }
        //kör loopen tills användaren har skrivit ett nummer, sammt gör en try parse med answer och kollar att det går
        return j;
        //retunerar numret som j
    }
    //kollar så att det är ett nummer och inte text
    public int GetNummber(int start, int end)
    {
        int i = GetNummber();
        //får ett värde på i från metoden GetNummber
        while (!(i >= start) || !(i <= end))
        {
            Console.WriteLine("Skriv ett nummer mellan " + start + "-" + end);
            i = GetNummber();
            //ändrar värdet på i från metoden GetNummber
        }
        //kör loopen medans i inte är mer än start och mindre än end
        return i;
    }
    //metod för att få ett nummer mellan angivna parametrar
    public bool YesAndNo()
    {
        while (true)
        {
            string? i = Console.ReadLine().ToUpper();
            //får en string i av consolereadline och sen omvandlar den till to upper
            if (i == "Y")
            {
                return true;
                //om input = Y så returnerar den true
            }
            if (i == "N")
            {
                return false;
                //om N så returnerar den 
            }
            else
            {
                Console.WriteLine("Skriv Y eller N");
            }
        }

    }
    //metod för att få en bool på input Y/N
}
