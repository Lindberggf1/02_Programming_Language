using Revisao_11.Entidade.Enums;

namespace Revisao_11.Entidade
{
    class Retangulo : FiguraGeometrica
    {
        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
