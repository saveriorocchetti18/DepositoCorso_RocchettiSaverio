using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int a=10,b=10;
        if (a > b)
        {
            Console.WriteLine($"{a} maggiore di {b}");
        }
        else
        {
            Console.WriteLine($"{a} minore o uguale di {b}");
        }

        int voto=28;
        if (voto >= 30)
        {
            Console.WriteLine("Eccellente");
        }
        else if (voto >= 18)
        {
            Console.WriteLine("Sufficiente");
        }

        int eta=15;
        if (eta >= 18)
        {
            Console.WriteLine("Maggiorenne");
        }
        else if (eta >= 13)
        {
            Console.WriteLine("Adolescente");
        }
        else
        {
            Console.WriteLine("Bambino");
        }

        string giorno="lunedi";
        switch (giorno)
        {
            case "lunedi":
            Console.WriteLine("inizio settimana");
            break;
            case "venerdi":
            Console.WriteLine("quasi weekend");
            break;
            default:
            Console.WriteLine("altro giorno");
            break;
        }
    }
}
