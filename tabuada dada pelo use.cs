using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meu_lindo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tabuada genérica


            int blu;
            int bla;
            string cont;
            do
            {
                Console.Clear();
                Console.Write("manda um numero para o teu pai, que eu lhe darei a tabuada completa do mesmo: ");
                blu = int.Parse(Console.ReadLine());
                for (bla = 1; bla <= 10; bla++)
                {
                    Console.WriteLine(bla + " x " + blu + " = " + (blu * bla));
                }
                Console.Write("deseja continuar(S/N)? : ");
                cont = Console.ReadLine();
            }
            while (cont == "s" || cont == "S" || cont == "Sim" || cont == "sim");
            Console.ReadKey();

        }
    }
}
