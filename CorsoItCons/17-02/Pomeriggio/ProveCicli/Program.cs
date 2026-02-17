using System;

class Program
{
    static void Main(string[] args)
    {
        bool continua=true;
        while (continua)
        {
            Console.WriteLine("Ciclo in esecuzione");
            continua=bool.Parse(Console.ReadLine());
        }

        int continua2=0;
        while (continua2 < 10)
        {
            Console.WriteLine("Ciclo in esecuzione");
            continua2+=1;
            Console.WriteLine(continua2);
        }
    }
}