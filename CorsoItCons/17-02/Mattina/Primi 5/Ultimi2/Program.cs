using System;

class Program
{
    static void Main(string[] args)
    {
        //Esercizio 4
        Console.Write("Inserisci un numero intero: ");
        string n1=Console.ReadLine();
        Console.Write("Inserisci un numero con la virgola: ");
        string n2=Console.ReadLine();

        int n1casting=int.Parse(n1);
        float n2casting=float.Parse(n2);

        Console.WriteLine("Somma: "+((float)(n1casting+n2casting)));

        //Esercizio 5
        Console.Write("Inserisci la tua età: ");
        string eta=Console.ReadLine();
        Console.Write("Inserisci l'altezza ");
        string altezza=Console.ReadLine();
        
        int etaCast=int.Parse(eta);
        float altezzaINT=float.Parse(altezza);

        Console.WriteLine("Somma: "+((int)(etaCast+altezzaINT)));


        //Esercizio 6
        Console.WriteLine("Inserisci 3 numeri: ");
        string x1=Console.ReadLine();
        string x2=Console.ReadLine();
        string x3=Console.ReadLine();

        int x1cast=int.Parse(x1);
        int x2cast=int.Parse(x2);
        int x3cast=int.Parse(x3);

        Console.WriteLine(!((x1cast>x3cast && x2cast<x1cast) || x2cast>x1cast));
    }
}
