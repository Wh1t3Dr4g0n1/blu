// Elabore algoritmo
// Fluxograma
// Progamação c# console
// que mostre uma sequencia de numeros pares
// apartir de um limite
// especificado pelo usuário


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
            int blu;
            int bla;
            int ble;
            Console.WriteLine("lhe darei uma quantia de numeros pares para você de acordo com o limite que você me der");
            Console.Write("inicio do limite: ");
            bla = int.Parse(Console.ReadLine());
            Console.Write("fim do limite: ");
            blu = int.Parse(Console.ReadLine());
            for (ble = bla; ble <= blu; ble++)
            {
                if (ble % 2 == 0)
                    Console.WriteLine(ble);
            }

            Console.ReadKey();
        }
    }
}
