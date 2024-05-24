namespace RPG_Game;

public class ForrestItems : Item
{
    public ForrestItems()
    {
        Name = GetName();
        //ger forrest items ett nytt namn från arrayn forrestitems vid konstrukt
        Space = 1;
        value = Random.Shared.Next(10, 50);
        //ger value ett random värde mellan 10 och 50
    }
    string GetName()
    {
        string[] forrestItemsNames = new string[] //skapar array forrestItemsNames med namn på items
        {
        "Mystisk Svamp",
        "Glödande Svamp",
        "Förhäxad Barkbit",
        "Trollkvist",
        "Mossbevuxen Sten",
        "Gyllene Ekollon",
        "Förtrollad Fjäril",
        "Månljusblomma",
        "Sagoberlock",
        "Skogsalvkrona",
        "Drakfjäril",
        "Trollrot",
        "Sagobär",
        "Förhäxad Lykta",
        "Mossig Portal",
        "Runsten",
        "Glimmervatten"
        };
        int i = Random.Shared.Next(forrestItemsNames.Length);
        //får ett random värde på i från max värdet array forrest items names längd
        return forrestItemsNames[i];
        //returnerar namnet ur array forrest items med index i
    }
}
