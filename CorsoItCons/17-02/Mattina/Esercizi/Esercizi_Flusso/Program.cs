using System;

class Program
{
    const int maggiore=18;
    static void Main(string[] args)
    {
        //Esercizio 1
        Console.WriteLine("Inserisci la tua età: ");
        string e=Console.ReadLine();
        int eta=int.Parse(e);
        if (eta >= maggiore)
        {
            Console.WriteLine("Sei maggiorenne!");
        }
        if (eta < maggiore)
        {
            Console.WriteLine("Sei minorenne!");
        }

        //Esercizio 2
        Console.WriteLine("Inserisci il prezzod del prodotto: ");
        string p=Console.ReadLine();
        float prezzo=float.Parse(p);
        prezzo-=prezzo*0.1f;
        if (prezzo > 100)
        {
            Console.WriteLine("Il prezzo finale, con lo sconto, supera i 100 euro.");
        }

        //Esercizio 3
        Console.WriteLine("Inserisci 3 numeri: ");
        string n1=Console.ReadLine();
        string n2=Console.ReadLine();
        string n3=Console.ReadLine();
        double numero1=double.Parse(n1);
        double numero2=double.Parse(n2);
        double numero3=double.Parse(n3);
        if ((numero1 + numero2 + numero3) / 3>=60)
        {
            Console.WriteLine("Prova Superata");
        }
        else
        {
            Console.WriteLine("Prova Fallita");
        }

        //Esercizio 4 Extra
        if(numero1 > numero2 && numero2 > numero1)
        {
            Console.WriteLine("Verificato");
        }
    }
}
