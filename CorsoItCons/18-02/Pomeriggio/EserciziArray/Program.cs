using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string scelta;
        int l;
        string[]arrays;
        int[]arrayi;
        do
        {
            Console.WriteLine("Vuoi inserire un array di stringhe o di interi? S per stringhe, I per interi: ");
            scelta=Console.ReadLine();
            Console.WriteLine("Quanto deve essere lungo l'array?");
            l=int.Parse(Console.ReadLine());
            if (scelta == "S")
            {
                arrays=new string[l];
                for(int i = 0; i < arrays.Length; i++)
                {
                    Console.WriteLine($"Inserisci il {i+1} elemento: ");
                    arrays[i]=Console.ReadLine();
                }

                Console.WriteLine("Stampa Array: ");
                for(int i = 0; i < arrays.Length; i++)
                {
                    Console.WriteLine(arrays[i]);
                }
            }
            else
            {
                arrayi=new int[l];
                for(int i = 0; i < arrayi.Length; i++)
                {
                    Console.WriteLine($"Inserisci il {i+1} elemento: ");
                    arrayi[i]=int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Stampa Array: ");
                for(int i = 0; i < arrayi.Length; i++)
                {
                    Console.WriteLine(arrayi[i]);
                }
            }

            Console.WriteLine("Vuoi ripetere? Premere Si per ripetere, No per uscire: ");
            scelta=Console.ReadLine();
        }
        while(scelta!="No");

        Console.WriteLine("Sei uscito correttamente dal programma!");
    }
}
