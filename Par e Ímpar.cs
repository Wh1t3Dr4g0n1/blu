// data da aula: 13/03/2025

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    int num, resto;
    Console.Write("digita ai amig: ");
    num = int.Parse(Console.ReadLine());
    resto = num % 2;
    if (resto == 0)
    Console.WriteLine("Par");
    else
    Console.WriteLine("Impar");
    }
    
}
