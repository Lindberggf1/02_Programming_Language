using System.Globalization;

namespace Revisao_10.Entidade
{
    class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega)
            : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public double TotalPrice()
        {
            return Preco + TaxaAlfandega;
        }

        public override string PriceTag()
        {
            return Nome
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (taxa alfandegária: $ "
                + TaxaAlfandega.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
