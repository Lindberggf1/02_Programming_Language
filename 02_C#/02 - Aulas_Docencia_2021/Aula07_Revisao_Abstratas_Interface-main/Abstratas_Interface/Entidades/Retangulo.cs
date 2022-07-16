using System.Globalization;

namespace Abstratas_Interface.Entidades
{
    class Retangulo : Figura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return "Rectangle color = "
                + Color
                + ", width = "
                + Largura.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Altura.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
