using System;
using System.Collections.Generic;
using System.Globalization;
using Revisao_11.Entidade;
using Revisao_11.Entidade.Enums;

namespace Revisao_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FiguraGeometrica> list = new List<FiguraGeometrica>();

            Console.Write("Insira o número de figuras geométricas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Figura #{i} dados:");
                Console.Write("Retangulo ou Circulo (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor (Black/Blue/Red): ");
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Largura: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(width, height, cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(radius, cor));
                }
            }

            Console.WriteLine();
            Console.WriteLine("AREA DAS FIGURAS GEOMETRICAS:");
            foreach (FiguraGeometrica figura in list)
            {
                Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
