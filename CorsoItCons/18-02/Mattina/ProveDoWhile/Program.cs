using System;

class Program
{
    static void Main(string[] args)
    {
        bool continua=true;
        do
        {
            Console.WriteLine("Ciclo in esecuzione");
            continua=bool.Parse(Console.ReadLine());
        }
        while(!continua);
    }
}
