using System;

public class seila
{
    public static void Main(string[] args)
    {
    Console.WriteLine("Exibir sua idade em dias, meses e anos");
    int anoatual,anonascto,idade,meses,dias;
    Console.Write("Dig o ano de nascimento: ");
    anonascto = Convert.ToInt32(Console.ReadLine());
    Console.Write("Dig o ano atual: ");
    anoatual = Convert.ToInt32(Console.ReadLine());
    idade = anoatual - anonascto;
    Console.WriteLine("Sua idade e " + idade + " anos");
    meses = idade * 12;
    Console.WriteLine("Sua idade em meses e " + meses + " meses");
    dias = idade * 365;
    Console.WriteLine("Sua idade em dias e " + dias + " dias");
    }
}