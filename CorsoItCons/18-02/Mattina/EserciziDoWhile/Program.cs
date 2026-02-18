using System;
using System.ComponentModel;
using System.Xml.Schema;

class Program
{
    const int password=12345;
    static void Main(string[] args)
    {
        //ESERCIZIO 1
        int pass,tentativi=0;
        Console.WriteLine("Inserisci una password numerica: ");
        do
        {
            pass=int.Parse(Console.ReadLine());
            tentativi++;
            if (pass != password)
            {
                Console.WriteLine("Password errata. Riprovare");
            }

        }while(pass!=password && tentativi<3);

        //ESERCIZIO 2
        int n,numeri=0,somma=0;
        Console.WriteLine("Inserisci una lista di numeri. Premere 0 per terminare: ");
        do
        {
            n=int.Parse(Console.ReadLine());
            if (n != 0)
            {
                somma+=n;
                numeri++;
            }
        }
        while(n!=0);

        Console.WriteLine($"La somma dei numeri inseriti corrisponde a {somma} e hai inserito in totale {numeri} numeri:");

        //ESERCIZIO 3
        string scelta;
        do
        {
            Console.WriteLine("Che operazione vuoi effettuare?");
            char op=char.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il primo numero: ");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero: ");
            int n2=int.Parse(Console.ReadLine());
            switch (op)
            {
                case '+':
                Console.WriteLine($"Il risultato è {n1+n2}");
                break;
                case '*':
                Console.WriteLine($"Il risultato è {n1*n2}");
                break;
                case '-':
                Console.WriteLine($"Il risultato è {n1-n2}");
                break;
                default:
                Console.WriteLine($"Il risultato è {n1/n2}");
                break;
            }

            Console.WriteLine("Vuoi continuare?");
            scelta=Console.ReadLine();

        }while(scelta=="Si");
    }
}