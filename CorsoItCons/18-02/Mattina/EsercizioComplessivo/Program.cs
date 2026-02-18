using System;

class Program
{
    static void Main(string[] args)
    {
        string inizio,nomeutente="",password="",utenteacc,passwordacc,scelta;
        int timer;
        Console.WriteLine("SISTEMA UTENTE\n1.REGISTRAZIONE\n2.ACCESSO\n3.ESCI");
        inizio=Console.ReadLine();
        do
        {
            switch (inizio)
            {
                case "1":
                    Console.WriteLine("Inserisci un nome utente:");
                    nomeutente=Console.ReadLine();
                    Console.WriteLine("Inserisci una password:");
                    password=Console.ReadLine();
                    Console.WriteLine("Registrazione avvenuta con successo");
                    break;
                case "2":
                    Console.WriteLine("Inserisci il tuo nome utente: ");
                    utenteacc=Console.ReadLine();
                    Console.WriteLine("Inserisci la tua password: ");
                    passwordacc=Console.ReadLine();
                    if(utenteacc!=nomeutente || passwordacc != password)
                    {
                        Console.WriteLine("Nome utente o password errati.");
                    }
                    else
                    {
                        Console.WriteLine("Accesso eseguito correttamente");
                        do
                        {
                            Console.WriteLine("Inserire il numero da cui far partire il conto alla rovescia: ");
                            timer=int.Parse(Console.ReadLine());
                            for(int i = timer; i >= 0; i--)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("Vuoi ripetere il conto alla rovescia? Premere Si per ripetere, No per uscire: ");
                            scelta=Console.ReadLine();
                        }
                        while(scelta=="Si");
                    }
                    break;
                default:
                Console.WriteLine("Sei uscito correttamente dal programma!");
                break;
            }
            if (inizio != "3")
            {
                Console.WriteLine("SISTEMA UTENTE\n1.REGISTRAZIONE\n2.ACCESSO\n3.ESCI");
                inizio=Console.ReadLine();
                if (inizio == "3")
                {
                    Console.WriteLine("Sei uscito correttamente dal programma!");
                }
            }
        }
        while(inizio!="3"); 
    }
}