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

            Console.Write("manda um numero para o teu pai, que eu lhe darei a tabuada completa do mesmo: ");
            int blu;
            int bla;
            blu = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================================");
            for (bla = 1; bla <= 10; bla++)
            {
                Console.WriteLine(blu + " x " + bla + " = " + (blu * bla));
            }
            Console.WriteLine("=====================================");
            Console.ReadKey();
        }
    }
}
