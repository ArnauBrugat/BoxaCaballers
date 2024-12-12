namespace BoxaCaballers;

public class Boxejador
{
    private string Nom { get; set; }  
    private int Vida { get; set; }
    private int copsRebuts { get; set; }
    
    public List<string> Proteccions { get; set; }

    private static readonly List<string> PartsCobrir = new List<string> { "cap", "panxa", "esquerra", "dreta" };
    
    public Boxejador(string nom, int vida)  
    {  
        Nom = nom;
        Vida = vida;
        copsRebuts = 0;
        Proteccions = SeleccionarProteccions();
    }
    
    private List<string> SeleccionarProteccions()
    {
        Random rand = new Random();
        var proteccions = new List<string>();

        var zonesDisponibles = new List<string>(PartsCobrir);
        int index;
        while (proteccions.Count == 3)
        {
            index = rand.Next(zonesDisponibles.Count);
            proteccions.Add(zonesDisponibles[index]);
        }

        return proteccions;
    }

    public bool RebreCop(string zona)
    {
        if (Proteccions.Contains(zona))
        {
            Console.WriteLine($"{Nom} es protegeix de {zona}");
            return false;
        }

        copsRebuts++;
        Console.WriteLine($"{Nom} rep un cop a {zona}!");

        return copsRebuts >= Vida;
    }
}
    