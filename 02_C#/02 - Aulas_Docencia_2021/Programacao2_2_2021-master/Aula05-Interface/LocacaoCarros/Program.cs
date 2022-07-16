using System;
using System.Globalization;
using LocacaoCarros.Entidade;
using LocacaoCarros.Servicos;

namespace LocacaoCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel");
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Início (dd/MM/yyyy HH:mm): ");
            DateTime dtInicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); //Parseexact pega a string para convertar para hora
            Console.Write("Retorno (dd/MM/yyyy HH:mm): ");
            DateTime dtFim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com o preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instanciar as entidades
            AluguelCarro aluguelCarro = new AluguelCarro(dtInicio, dtFim, new Veiculo(modelo));

            //instanciar os servicos
            ServicoAluguel servicoAluguel = new ServicoAluguel(precoHora, precoDia);

            //agora conseguimos gerar a fatura com o metodo de processar fatura
            servicoAluguel.ProcessarFatura(aluguelCarro);

            //
            Console.WriteLine("FATURA:");
            Console.WriteLine(aluguelCarro.Fatura);
        }
    }
}
