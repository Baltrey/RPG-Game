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
    public bool YesAndNo()
    {
        while (true)
        {
            string? i = Console.ReadLine().ToUpper();
            if (i == "Y")
            {
                Console.Clear();
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
