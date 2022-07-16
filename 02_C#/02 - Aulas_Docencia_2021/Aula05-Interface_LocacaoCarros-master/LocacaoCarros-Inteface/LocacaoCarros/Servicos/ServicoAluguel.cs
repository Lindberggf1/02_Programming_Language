using System;
using LocacaoCarros.Entidade;

namespace LocacaoCarros.Servicos
{
    class ServicoAluguel
    {
        public double PrecoHora { get; private set; } // vamos proteger para nao serem auterados. 
        public double PrecoDia { get; private set; }

        //criar dependencia, mas esta forma nao é boa
        //private ServicoImpostoBrasil _servicoImpostoBrasil = new ServicoImpostoBrasil();

        //agora assim depende da Interfacer IServicoImposto.
        //vamos esperar um servico de imposto qualquer. Apenas declarar variavel da Interface e vamos passar no construtor
        private IServicoImposto _servicoImposto;

        //construtor
        //neste momento fazemos a inversao de dependencia onde a ServicoAluguel nao mais controla o servicoImposto, 
        //vai apenas receber o objeto instanciado e vai atribuir.
        public ServicoAluguel(double precoHora, double precoDia, IServicoImposto servicoImposto)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;

            //passar o parametro da interface
            _servicoImposto = servicoImposto;
        }

        //metodo para processar/criar a fatura
        public void ProcessarFatura(AluguelCarro aluguelCarro)
        {

            TimeSpan duracao = aluguelCarro.DtFim.Subtract(aluguelCarro.DtInicio); //Subtract realiza a operacao de subtracao entre este parametros

            double pagamentoBasico = 0.0;

            if (duracao.TotalHours <= 12.0) // total hora menor ou igual a 12 horas.
            {
                //o pagamento basico sera o preco por hora multiplicado pela duracao total de horas arredondado para cima.
                pagamentoBasico = PrecoHora * Math.Ceiling(duracao.TotalHours); // a Ceiling realiza o arredondamento para cima.
            }
            else
            {
                // caso for mais que 12h, ser cobrado o preco por dia multiplicado pela duracao total de dias arredondado para cima.
                pagamentoBasico = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            //vamos calcular o valor do imposto. Sera calculado pelo servico de imposto baseado no pagamento basico passado no parametro.
            //double imposto = _servicoImpostoBrasil.Imposto(pagamentoBasico);
            double imposto = _servicoImposto.Imposto(pagamentoBasico);

            //vamos intanciar o aluguel de carro passando agora todos este paramentros calculados
            aluguelCarro.Fatura = new Fatura(pagamentoBasico, imposto);

        }
    }

}
