using System;
using System.Globalization;

namespace Revisao_10.Entidade
{
    class ProdutoUsado : Produto
    {
        public DateTime DtFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dtFabricacao)
            : base(nome, preco)
        {
            DtFabricacao = dtFabricacao;
        }

        public override string PriceTag()
        {
            return Nome
                + " (used) $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data de fabricacao: "
                + DtFabricacao.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
