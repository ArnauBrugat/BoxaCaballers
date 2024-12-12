// See https://aka.ms/new-console-template for more information
namespace BoxaCaballers;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Nom del Boxejador1: ");  
        string nomBoxer1 = Console.ReadLine(); 
        Console.WriteLine($"Cuanta vida ha de tenir {nomBoxer1}");
        int Vida1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Nom del boxejador2: ");  
        string nomBoxer2 = Console.ReadLine();  
        Console.WriteLine($"Cuanta vida ha de tenir {nomBoxer2}");
        int Vida2 = int.Parse(Console.ReadLine());
        //Informatiu de com funciona el programa
        Console.WriteLine($"Comença {nomBoxer1} a golpejar a {nomBoxer2} mentre {nomBoxer2} es protegeix 3 parts de 4 (CostatDret, CostatEsquerra, Cap i Panxa) possibles per cobrir en el seu cos. Un cop {nomBoxer1} ha atacat, es el torn de {nomBoxer2} i aixi repetitivament fins que un cau desplomat");
        BoxaCaballers.Boxejador boxejador1 = new Boxejador(nomBoxer1, Vida1);
        BoxaCaballers.Boxejador boxejador2 = new Boxejador(nomBoxer2, Vida2);
        BoxaCaballers.Lluita lluita = new BoxaCaballers.Lluita(boxejador1, boxejador2);
        lluita.ComencaLluita();
    }
}