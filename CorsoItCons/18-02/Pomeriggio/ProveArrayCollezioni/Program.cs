using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        /*int[]voti=new int[5];
        for(int i = 0; i < voti.Length; i++)
        {
            Console.WriteLine($"Inserisci il {i+1} voto");
            voti[i]=int.Parse(Console.ReadLine());
        }

        //CALCOLO DELLA MEDIA
        float somma=0;
        for(int i = 0; i < voti.Length; i++)
        {
            somma+=voti[i];
        }

        float media=somma/voti.Length;
        Console.WriteLine("La media corrisponde a "+media);


        string parola="CSharp";
        Console.WriteLine("Caratteri della stringa: ");
        foreach(char carattere in parola)
        {
            Console.WriteLine(carattere);
        }*/

        int[]prova=new int[4];
        for(int i = 0; i < prova.Length; i++)
        {
            Console.WriteLine($"Inserisci il {i+1} numero");
            prova[i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Numeri dell'array: ");
        foreach(int cifra in prova)
        {
            Console.WriteLine(cifra);
        }
    }
}