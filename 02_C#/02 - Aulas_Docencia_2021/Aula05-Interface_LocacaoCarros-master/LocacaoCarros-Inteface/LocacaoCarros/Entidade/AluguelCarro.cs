using System;

namespace LocacaoCarros.Entidade
{
    class AluguelCarro
    {
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }

        //associacoes/dependencias com as outras entidades
        public Veiculo Veiculo { get; private set; } // associacao com classe Veiculo
        public Fatura Fatura { get; set; }           //associacao com classe Fatura

        public AluguelCarro(DateTime dtInicio, DateTime dtFim, Veiculo veiculo)
        {
            DtInicio = dtInicio;
            DtFim = dtFim;
            Veiculo = veiculo;
            Fatura = null;  // esta fatura so sera processada quando processar o aluguel de carro
        }
    }
}
