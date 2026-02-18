using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        //ESERCIZIO 1
        Console.WriteLine("Inserisci un numero intero: ");
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine($"Tabellina del {n}: ");
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n*i);
        }

        //ESERCIZIO 2
        float somma=0,media=0;
        Console.WriteLine("Quanti numeri vuoi inserire? ");
        int x=int.Parse(Console.ReadLine());
        for(int i = 0; i < x; i++)
        {
            somma+=float.Parse(Console.ReadLine());
        }
        Console.WriteLine($"La media degli elementi inseriti corrisponde a {somma/x}");

        //ESERCIZIO 3
        int xx;
        do
        {
            Console.WriteLine("Inserisci un numero positivo: ");
            xx=int.Parse(Console.ReadLine());
            if (xx <= 0)
            {
                Console.WriteLine("Errore. Inserire un numero positivo: ");
            }
        }
        while(xx<=0);
        
        int fattoriale=1;
        for(int i = 2; i <= xx; i++)
        {
            fattoriale*=i;
        }
        Console.WriteLine($"Il fattoriale di {xx} corrisponde a {fattoriale}");
    }
}
