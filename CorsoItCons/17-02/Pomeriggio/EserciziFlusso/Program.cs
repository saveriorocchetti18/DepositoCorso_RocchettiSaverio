using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        const int PASSWORD=12345;
        //ESERCIZIO 1
        Console.WriteLine("Inserisci numero:");
        int j=int.Parse(Console.ReadLine());
        if (j % 2 == 0)
        {
            Console.WriteLine("Il numero inserito è pari!");
        }
        else
        {
            Console.WriteLine("Il numero inserito è dispari!");
        }

        //ESERCIZIO 2
        Console.WriteLine("Inserisci la password: ");
        int p=int.Parse(Console.ReadLine());
        if (p == PASSWORD)
        {
            Console.WriteLine("ACCESSO CONSENTITO");
        }
        else
        {
            Console.WriteLine("ACCESSO NEGATO");
        }

        //ESERCIZIO 3 EXTRA
        Console.WriteLine("Inserisci due numeri:");
        double n1=double.Parse(Console.ReadLine());
        double n2=double.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci un operatore: (+ o -)");
        char operatore=char.Parse(Console.ReadLine());
        if(operatore!='+' && operatore!= '-')
        {
            Console.WriteLine("Operatore non valido!");
        }
        else
        {
            if (operatore == '+')
            {
                Console.WriteLine($"Il risultato è: {n1+n2}");
            }
            else
            {
                Console.WriteLine($"Il risultato è: {n1-n2}");
            }
        }

        //IF-ELSE IF

        //ESERCIZIO 1
        Console.WriteLine("Inserisci un voto da 1 a 10: ");
        int voto=int.Parse(Console.ReadLine());
        if (voto >= 9)
        {
            Console.WriteLine("Ottimo");
        }
        else if (voto >= 7)
        {
            Console.WriteLine("Buono");
        }
        else if (voto >= 5)
        {
            Console.WriteLine("Sufficiente");
        }
        else
        {
            Console.WriteLine("Insufficiente");
        }

        //ESERCIZIO 2
        Console.WriteLine("Inserisci l'altezza: ");
        float altezza=float.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il peso: ");
        float peso=float.Parse(Console.ReadLine());

        float BMI=peso/(altezza*altezza);
        if (BMI >= 30)
        {
            Console.WriteLine("Obesità");
        }
        else if (BMI >= 25)
        {
            Console.WriteLine("Sovrappeso");
        }
        else if (BMI >= 18.5)
        {
            Console.WriteLine("Normopeso");
        }
        else
        {
            Console.WriteLine("Sottopeso");
        }

        //ESERICIZIO 3 EXTRA
        Console.WriteLine("Inserisci una temperatura in Celsius");
        float t=float.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci la scala verso cui effetturare la conversione: ");
        string conversione=Console.ReadLine();
        if (conversione == "Farhenheit")
        {
            Console.WriteLine($"La temperatura inserita convertita in Fahrenheit è: {t/3*5}");
        }
        else if (conversione == "Kelvin")
        {
            Console.WriteLine($"La temperatura inserita convertita in Kelvin è: {t/3*7}");
        }
        else
        {
            Console.WriteLine($"La temperatura inserita convertita in Rankine è: {t/3*9}");
        } */

        //SWITCH

        //ESERCIZIO 1
        Console.WriteLine("Inserisci un numero da 1 a 7: ");
        string n=Console.ReadLine();
        switch (n)
        {
            case "1":
            Console.WriteLine("Lunedi");
            break;
            case "2":
            Console.WriteLine("Martedi");
            break;
            case "3":
            Console.WriteLine("Mercoledi");
            break;
            case "4":
            Console.WriteLine("Giovedi");
            break;
            case "5":
            Console.WriteLine("Venerdi");
            break;
            case "6":
            Console.WriteLine("Sabato");
            break;
            default:
            Console.WriteLine("Domenica");
            break;
        }

        //ESERCIZIO 2
        Console.WriteLine("Quale figura geometrica vuoi considerare? (Quadrato, Cerchio o Triangolo)");
        string figura=Console.ReadLine();

        switch (figura)
        {
            case "Quadrato":
            Console.WriteLine("Inserisci la misura del lato: ");
            int lato=int.Parse(Console.ReadLine());
            Console.WriteLine($"La misura dell'area corrisponde a {lato*lato}");
            break;
            case "Cerchio":
            Console.WriteLine("Inserisci la misura del raggio: ");
            int r=int.Parse(Console.ReadLine());
            Console.WriteLine($"La misura dell'area corrisponde a {3.14*r*r}");
            break;
            default:
            Console.WriteLine("Inserisci la misura rispettivamente della base e dell'altezza: ");
            int b=int.Parse(Console.ReadLine());
            int h=int.Parse(Console.ReadLine());
            Console.WriteLine($"La misura dell'area corrisponde a {(b*h)/2}");
            break;
        }
    } 
}
