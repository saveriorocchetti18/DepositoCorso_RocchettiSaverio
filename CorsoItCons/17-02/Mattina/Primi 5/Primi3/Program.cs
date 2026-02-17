using System;

class Program
{
    static void Main(string[] args)
    {
        //somma
        int x=10;
        int y=12;
        Console.WriteLine($"Somma: {x+y}");

        //prezzo scontato
        double prezzo=35.5d;
        Console.WriteLine($"Prezzo scontato del 20%: {prezzo-(0.2*prezzo)}");

        //comparazione
        float numero=32;
        Console.WriteLine(numero>0);
        

    }
}