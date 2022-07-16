using System;
using Revisao_11.Entidade.Enums;

namespace Revisao_11.Entidade
{
    class Circulo : FiguraGeometrica
    {
        public double Raio { get; set; }

        public Circulo(double raio, Color cor): base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }

    }
}
