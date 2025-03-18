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
            Console.WriteLine($"As raízes são: x1 = {x1} e x2 = {x2}");
        }
        else 
            if (delta == 0)
        {
            // Uma raiz real (raiz dupla)
            double x = -b / (2 * a);
            Console.WriteLine($"A raiz é: x = {x}");
        }
        else
        {
            // Não há raízes reais
            Console.WriteLine("Não há raízes reais.");
        }
    }
}
