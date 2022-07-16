using System;
using Abstratas_Interface.Entidades;
using Abstratas_Interface.Entidades.Enum;

namespace Abstratas_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura s1 = new Circulo() { Raio = 2.0, Color = Color.PRETO };
            Figura s2 = new Retangulo() { Largura = 3.5, Altura = 4.2, Color = Color.BRANCO };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
