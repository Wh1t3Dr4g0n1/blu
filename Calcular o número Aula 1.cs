// data da aula: 11/03/2025

using System;

public class seila
{
    public static void Main(string[] args)
    {
    Console.WriteLine("Escolha um numero e e lhe darei em ao quadrado, a raiz, e o cosseno!");
    int quadrado,numero;
    double cosseno;
    double radiano;
    double raiz;
    Console.Write("Digite um numero: ");
    numero = Convert.ToInt32(Console.ReadLine());
    quadrado = numero * numero;
    Console.WriteLine("o quadrado do numero escolhido e: " +quadrado);
    raiz = Math.Sqrt(numero);
    Console.WriteLine("a raiz do numero escolhido e: " +raiz);
    radiano = numero * (Math.PI / 180);
    cosseno = Math.Cos(radiano);
    Console.WriteLine("O cosseno de e: " +cosseno);
    }
}
