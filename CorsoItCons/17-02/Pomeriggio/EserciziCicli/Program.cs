using System;

class Program
{
    static void Main(string[] args)
    {
        //ESERCIZIO 1
        int somma=0;
        Console.WriteLine("Inserisci un numero: ");
        int n=int.Parse(Console.ReadLine());
        while (n > 0)
        {
            somma+=n;
            Console.WriteLine("Inserisci un numero: ");
            n=int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"La somma dei numeri positvi inseriti è: {somma}");

        //ESERCIZIO 2
        const int segreto=95;
        Console.WriteLine("Inserisci un numero: ");
        int s=int.Parse(Console.ReadLine());
        while (s != segreto)
        {
            if (s > segreto)
            {
                Console.WriteLine("Il numero che hai inserito è maggiore rispetto al numero segreto.");
            }
            else
            {
                Console.WriteLine("Il numero che hai inserito è minore rispetto al numero segreto.");
            }

            Console.WriteLine("Prova ancora: ");
            s=int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Indovinato!");

        //ESERCIZIO 3
        float saldo=0;
        Console.WriteLine("1.Visualizza");
        Console.WriteLine("2.Deposita");
        Console.WriteLine("3.Preleva");
        Console.WriteLine("4.Esci");
        int scelta=int.Parse(Console.ReadLine());
        while (scelta != 4)
        {
            switch (scelta)
            {
                case 1:
                Console.WriteLine($"Il saldo attuale corrisponde a {saldo}");
                break;
                case 2:
                Console.WriteLine("Quanto vuoi depositare?");
                float soldi=float.Parse(Console.ReadLine());
                saldo+=soldi;
                break;
                case 3:
                Console.WriteLine("Quanto vuoi prelevare?");
                soldi=float.Parse(Console.ReadLine());
                saldo-=soldi;
                break;
                default:
                Console.WriteLine("Sei uscito correttamente!");
                break;
            }
        }
    }
}
