using System;

class Program
{
    static void Main(string[] args)
    {
        string inizio,nome_utente,password,utente_acc,password_acc,scelta;
        int timer;
        do
        {
            Console.WriteLine("SISTEMA UTENTE\n1.REGISTRAZIONE\n2.ACCESSO");
            inizio=Console.ReadLine();
            switch (inizio)
            {
                case 1:
                    Console.ReadLine("Inserisci un nome utente:");
                    nome_utente=Console.ReadLine();
                    Console.ReadLine("Inserisci una password:");
                    password_utente=Console.ReadLine();
                    Console.WriteLine("Registrazione avvenuta con successo");
                    break;
                case 2:
                    Console.WriteLine("Inserisci il tuo nome utente: ");
                    utente_acc=Console.ReadLine();
                    Console.WriteLine("Inserisci la tua password: ");
                    password_acc=Console.ReadLine();
                    if(utente_acc!=nome_utente || password_acc != password)
                    {
                        Console.WriteLine("Nome utente o password errati.");
                    }
                    else
                    {
                        Console.WriteLine("Accesso eseguito correttamente. Inserire un numero per il conto alla rovescia: ");
                        timer=int.Parse(Console.ReadLine());
                        for(int i = timer; i >= 0; i--)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                default:
                break;
            }
            Console.WriteLine("Vuoi uscire dal programma o vuoi ripetere? Premere Si per continuare, No per uscire: ");
            scelta=Console.ReadLine();
        }
        while(scelta=="Si"); 
    }
}