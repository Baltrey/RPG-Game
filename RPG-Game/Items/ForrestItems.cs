namespace RPG_Game;

public class ForrestItems : Item
{
    public int value { get; set; }
    public ForrestItems()
    {
        Name = GetName();
        //ger forrest items ett nytt namn från arrayn forrestitems vid konstrukt
        Space = 1;
        value = Random.Shared.Next(10, 50);
    }
    string GetName()
    {
        string[] forrestItemsNames = new string[]
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
        return forrestItemsNames[i];
    }
}
