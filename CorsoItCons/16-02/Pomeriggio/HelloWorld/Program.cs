using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

//classe
class Program
{
    const int NUM=240;
    public static readonly string Nome="Mirko";
    static void Main(string[] args)
    {
        Console.WriteLine("HELLO WORLD");

        int numero=10;
        float decimaleFloat=3.14f;
        double decimaleDouble=3.14d;
        char lettera='A';
        bool condizione=true;
        string saluto="Ciao a tutti!";

        /*
        Console.WriteLine("Numero: "+numero);
        Console.WriteLine("Decimale: "+decimaleFloat);
        Console.WriteLine("Lettera: "+lettera);
        Console.WriteLine("Condizione: "+condizione);
        Console.WriteLine("Saluto: "+saluto);

        Console.WriteLine("Costante: "+NUM);
        Console.WriteLine("Costante Read: "+Nome);

        int pi=3;
        float piG=pi;  //casting implicito

        float flo=143.43f;
        int floI=(int)flo;  //casting esplicito

        Console.WriteLine("PiG "+piG);
        Console.WriteLine("floI:"+floI);

        Console.Write("Come ti chiami?");
        string tuoNome=Console.ReadLine();
        Console.Write($"Ciao {tuoNome}!");

        Console.Write("Dammi un numero");
        string n1=Console.ReadLine();
        Console.Write("Dammi un altro numero");
        string n2=Console.ReadLine();

        int numero1=int.Parse(n1);
        int numero2=int.Parse(n2);

        Console.WriteLine("N1: "+numero1);
        Console.WriteLine("N2: "+numero2);*/

        int x=1;
        int y=23;
        Console.WriteLine("Operatori aritmetici:");
        Console.WriteLine($"x+y={x+y}");
        Console.WriteLine($"x*y={x*y}");
        Console.WriteLine($"x/y={x/y}");
        Console.WriteLine($"x%y={x%y}");
        Console.WriteLine("Operatori assegnazione:");
        Console.WriteLine($"incremento x {x++}");
        Console.WriteLine($"{x}");
        Console.WriteLine($"decremento y {y--}");
        Console.WriteLine($"{y}");

        int xx=12;
        int yy=13;
        Console.WriteLine("Operatori logici:");
        Console.WriteLine($"AND: {xx<yy && xx>=10}"); //true
        Console.WriteLine($"OR: {xx>yy || xx>=10}"); //true
        Console.WriteLine($"NOT: {!(xx<yy)}"); //false

    }
}

/*
    static void Main(string[] args)
    {
        Console.WriteLine("HELLO WORLD");
    }*/