using Revisao_11.Entidade.Enums;

namespace Revisao_11.Entidade
{
    abstract class FiguraGeometrica
    {
        public Color Cor { get; set; }

        public FiguraGeometrica(Color cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }

}
