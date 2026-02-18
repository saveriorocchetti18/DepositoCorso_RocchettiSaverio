using System;

class Program
{
    static void Main(string[] args)
    {
        //ESERCIZIO 1
        int cifre=0,lettere=0;
        Console.WriteLine("Inserisci una frase: ");
        string frase=Console.ReadLine();
        foreach(char carattere in frase)
        {
            if (char.IsDigit(carattere))
            {
                cifre++;
            }
            else
            {
                lettere++;
            }
        }
        Console.WriteLine($"La frase contiene {cifre} cifre e {lettere} lettere. ");


        //ESERCIZIO 2
        Console.WriteLine("Inserisci una frase: ");
        string frase2=Console.ReadLine();
        string nuovaFrase="";
        foreach(char carattere in frase2)
        {
            if(carattere!=' ')
            {
                nuovaFrase+=carattere;
            }
        }
        Console.WriteLine($"La nuova frase senza spazi è {nuovaFrase}");

        //ESERCIZIO 3
        int vocali=0;
        Console.WriteLine("Inserisci una stringa: ");
        string parola=Console.ReadLine();
        parola=parola.ToLower();
        foreach(char carattere in parola)
        {
            if (carattere == 'a' || carattere == 'e' || carattere == 'i' || carattere == 'o' || carattere == 'u')
            {
                vocali++;
            }
        }
        Console.WriteLine($"La stringa contiene: {vocali} vocali");

        /*//ESERCIZIO 4
        Console.WriteLine("Inserisci una password: ");
        string password=Console.ReadLine();
        foreach(char carattere in password)
        {
            if(carattere)
        }*/

        //ESERCIZIO 5
        int numero_parole=0,alfabetici=0,spazi=0,punteggiatura=0;
        Console.WriteLine("Inserisci una stringa: ");
        string ultima=Console.ReadLine();

        string[]parole=ultima.Split();
        foreach(string parolasplit in parole)
        {
            numero_parole++;
        }

        foreach(char carattere in ultima)
        {
            if (char.IsLetter(carattere))
            {
                alfabetici++;
            }
            if (char.IsWhiteSpace(carattere))
            {
                spazi++;
            }
            if (char.IsPunctuation(carattere))
            {
                punteggiatura++;
            }
        }

        Console.WriteLine($"La stringa inserita contiene {numero_parole} parole, {alfabetici} caratteri alfabetici, {punteggiatura} segni di punteggiatura, {spazi} spazi");
    }
}
