namespace BoxaCaballers;

public class Lluita
{
    private Boxejador Boxejador1;
    private Boxejador Boxejador2;
    private Random random;
    private readonly string[] zones = { "cap", "panxa", "esquerra", "dreta" };
    public Lluita(Boxejador boxejador1, Boxejador boxejador2)
    {
        Boxejador1 = boxejador1;
        Boxejador2 = boxejador2;
        random = new Random();
    }
    public void ComencaLluita()
    {
        Console.WriteLine($"Combat entre {Boxejador1} i {Boxejador2}");
        Console.WriteLine("-------------------------------------");
        while (true)
        {
            if (RealitzarTorn(Boxejador1, Boxejador2)) break;
            if (RealitzarTorn(Boxejador2, Boxejador1)) break;
        }
    }
    private bool RealitzarTorn(Boxejador atacant, Boxejador defensor)
    {
        string zonaAtac = zones[random.Next(zones.Length)];
        Console.WriteLine($"— {atacant} pica: {ZonaColpejada(zonaAtac)}");

        List<string> zonesCovertes = new List<string>();
        for (int i = 0; i < 3; i++)
        {
            string zonaDef = zones[random.Next(zones.Length)];
            zonesCovertes.Add(zonaDef);
        }
        if (defensor.RebreCop(zonaAtac))
        {
            Console.WriteLine($"{defensor} CAU!");
            Console.WriteLine($"GUANYADOR: {atacant}");
            return true;
        }

        return false;
    }
    private string ZonaColpejada(string zona)
    {
        return zona switch
        {
            "cap" => "Cop a cap",
            "panxa" => "Cop a panxa",
            "esquerra" => "Cop a esquerra",
            "dreta" => "Cop a dreta",
            _ => "Protegit"
        };
    }
}