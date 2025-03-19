// data da aula: 13/03/2025
// 1. inicio
// 2. var a,b,c,delta,x:Real
// 3. Leia a
// 4. Leia b
// 5. Leia c
// 6. delta = b * b - 4 * a * c
// 7. Mostre "Delta:" , delta
// 8. Se (delta < 0)
//       Mostre  "Não Existe Raizes Reais"
// 	Senão Se (delta = 0)
// 	x = -b / 2 * a
// 	Mostre "x: " , x
//	Senão
//	x = (-b + √delta) / 2 * a
//	Mostre "x1: " , x
//	Fim-se
// 	Fim-se
// 9. Fim

using System;

class Program
{
    static void Main()
    {
        // Entrada dos coeficientes
        Console.Write("Digite o coeficiente a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o coeficiente b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o coeficiente c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Calculando o discriminante (delta)
        double delta = b * b - 4 * a * c;

        // Verificando as raízes com base no valor de delta
        if (delta > 0)
        {
            // Duas raízes reais e diferentes
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"As raizes sao: x1 = {x1} e x2 = {x2}");
        }
        else 
            if (delta == 0)
        {
            // Uma raiz real (raiz dupla)
            double x = -b / (2 * a);
            Console.WriteLine($"A raiz e: x = {x}");
        }
        else
        {
            // Não há raízes reais
            Console.WriteLine("Nao ha raizes reais.");
        }
    }
}
