using System;

public class blubla
{
    public static void Main(string[] args)
    {
        Console.WriteLine("escreve um número");
        double num;
        double dobro;
        double quadrado;
        double nume;
        double numer;
        Console.Write("escreve ai: ");
        numer = Convert.ToInt32 (Console.ReadLine());
        num = numer + numer;
        dobro = num * 2;
        quadrado = dobro * dobro;
        Console.WriteLine("tome: " + num);
        Console.WriteLine("toma: " + dobro);
        Console.WriteLine("tume: " + quadrado);
        
    }
}
