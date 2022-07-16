using Abstratas_Interface.Entidades.Enum;

namespace Abstratas_Interface.Entidades
{
    abstract class Figura
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
