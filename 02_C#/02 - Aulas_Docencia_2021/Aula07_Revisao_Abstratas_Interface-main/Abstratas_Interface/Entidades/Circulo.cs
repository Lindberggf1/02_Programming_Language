using System;
using System.Globalization;

namespace Abstratas_Interface.Entidades
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Raio.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
