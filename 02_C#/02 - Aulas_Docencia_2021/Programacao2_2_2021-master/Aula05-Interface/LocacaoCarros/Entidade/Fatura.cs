using System;
using System.Globalization;

namespace LocacaoCarros.Entidade
{
    class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }

        public Fatura(double pagamentoBasico, double imposto)
        {
            PagamentoBasico = pagamentoBasico;
            Imposto = imposto;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBasico + Imposto; }
        }

        public override string ToString()
        {
            return "Pagamento basico: "
                + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nImposto: "
                + Imposto.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento total: "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
