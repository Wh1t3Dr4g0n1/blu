// 1. ínicio
// 2. var: string nome 
// 3. var: double preço
// 4. Mostrar "dê o nome do produto e o valor"
// 5. var: double desconto
// 6. desconto = Preço * 0.10
// 7. var: double acrescimo
// 8. Se for parcelado em 2x
// 9. acrescimo = preço * 0.02
// 10. Se for parcelado em 3x a 10x
// 11. acrescimo = preço * 0.05





using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace meu_lindo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto, parcelac;
            double preco, precoa, precob, precoc, total;

            Console.WriteLine("==========================================");
            Console.WriteLine("Me diga qual o nome do produto e o preço: ");
            Console.Write("Nome do produto: ");
            produto = Console.ReadLine();
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Irá parcelar em quantas vezes?");
            Console.WriteLine("a vista / 2x / 3x / 4x / 5x / 6x / 7x / 8x / 9x / 10x)");
            Console.Write("Parcelas: ");
            parcelac = Console.ReadLine();
            {
                if (parcelac == "a vista")
                {
                    Console.Clear();
                    precoa = preco * 0.10;
                    total = preco - precoa;
                    Console.WriteLine("========================");
                    Console.WriteLine("Pagamento a vista.");
                    Console.WriteLine("Seu Produto: " + produto);
                    Console.WriteLine("O preço total é esse: {0:0.00}", total);
                }
            if (parcelac == "2x")
            {
                    Console.Clear();
                precob = preco * 0.02;
                total = precob + preco;
                    Console.WriteLine("========================");
                    Console.WriteLine("Pagamento parcelado em 2x.");
                    Console.WriteLine("Seu Produto: " + produto);
                    Console.WriteLine("O preço total é esse: {0:0.00}", total);
            }
              if (parcelac == "3x" || parcelac == "4x" || parcelac == "5x" || parcelac == "6x" || parcelac == "7x" || parcelac == "8x" || parcelac == "9x" || parcelac == "10x")
              {
                    Console.Clear();
                precoc = preco * 0.05;
                total = precoc + preco;
                    Console.WriteLine("========================");
                    Console.WriteLine("Pagamento parcelado de 3x a 10x.");
                    Console.WriteLine("Seu Produto: " + produto);
                Console.WriteLine("O preço total é esse: {0:0.00}", total);
              }
           }
            Console.ReadKey();
        }
    }
}
