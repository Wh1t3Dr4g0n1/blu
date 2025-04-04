// Crie um progama que solicite do usuario os seguintes dados:
// - nome
// - rg
// - cpf
// - idade
// - sexo
// - estado civil
// - salario bruto
//
// Calcule:
// - Desconto de 11% de INSS
// - Desconto de 5% de Conv. Médico
// - Desconto de Vale Transporte
// - Salário Línquido
//
// Obs: Se o funcinário do sexo "Masculino" 
// acrescente 1000,00 no Salário Línquido, caso 
// contrário acrescente 800,00 no Salário Línquido.
//
// Algoritmo
//
// 1. Início
// 2. var nome,rg, cpf, EC (estado civil), sexo: carater
//    var idade: inteiro
//    var SB (Salário Bruto),INSS, CM (Conv. Médico), VT (Vale Transporte), SL (Salário Línquido): real
// 3. Leia nome
// 4. Leia  rg
// 5. Leia cpf
// 6. Leia idade
// 7. Leia EC
// 8. Leia sexo
// 9. Leia SB
// 10. INSS = SB * 0.11
// 11. Mostre INSS
// 12. CM = SB * 0.06
// 13. Mostre CM
// 14. VT = SB * 0.06
// 15. Mostre VT
// 16. SL = SB - (INSS+CM+VT)
// 17. Mostre SL
// 18. Se (sexo = "M")
//        SL = SL + 1000.00
//  	Senão
//	      SL = SL + 800.00






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
            string nome, rg, cpf, EC, sexo, cont, conti;
            int idade;
            double SB, INSS, CM, VT, SL;

            do
            {
                Console.Clear();
                Console.WriteLine("=====================================================================");
                Console.WriteLine("Porfavor, precisarei de alguns dados seus para calcular o seu salário");
                Console.WriteLine("=====================================================================");
                Console.Write("Seu nome: ");
                nome = Console.ReadLine();
                Console.Write("Seu RG: ");
                rg = Console.ReadLine();
                Console.Write("Seu CPF: ");
                cpf = Console.ReadLine();
                Console.Write("Seu idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Seu sexo(Responda com Masculino/Feminino): ");
                sexo = Console.ReadLine();
                Console.Write("Seu Estado Civil: ");
                EC = Console.ReadLine();
                Console.Write("Seu Salário Líquido: ");
                SB = double.Parse(Console.ReadLine());

                INSS = SB * 0.11;
                CM = SB * 0.06;
                VT = SB * 0.06;
                SL = SB - (INSS + CM + VT);

                if (sexo == "Masculino" || sexo == "masculino")
                    SL = SL + 1000.00;
                else
                    SL = SL + 0.00;

                if (sexo == "Feminino" || sexo == "feminino")

                    SL = SL + 800.00;

                Console.Clear();
                Console.WriteLine("========================");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("RG: " + rg);
                Console.WriteLine("CPF: " + cpf);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Sexo: " + sexo);
                Console.WriteLine("Estado Civil: " + EC);
                Console.WriteLine("Salário Bruto: {0:0,00}", SB);
                Console.WriteLine("Seu INSS: {0:0,00}" + INSS);
                Console.WriteLine("Seu Convenio Médico: {0:0,00}", CM);
                Console.WriteLine("Seu Vale Transporte: {0:0,00}", VT);
                Console.WriteLine("Seu Salário: {0:0,00}", SL);
                Console.Write("está correto(S/N)?: ");
                conti = Console.ReadLine();

                if (conti == "s" || conti == "S" || conti == "sim" || conti == "Sim")
                Console.WriteLine("========================");
                Console.Write("Quer recomeçar(S/N)?: ");
                cont = Console.ReadLine();

                if (cont == "n" || cont == "N" || cont == "Não" || cont == "Nao" || cont == "não" || cont == "nao")
                    Console.WriteLine("(Pressione ENTER até fechar..)");

                if (cont == "n" || conti == "N" || conti == "Não" || conti == "Nao" || conti == "não" || conti == "nao")
            }
            while (cont == "s" || cont == "S" || cont == "sim" || cont == "Sim");
            Console.ReadKey();
        }
    }
}




