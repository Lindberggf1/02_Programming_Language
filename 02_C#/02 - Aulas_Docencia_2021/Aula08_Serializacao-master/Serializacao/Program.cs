using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //serialização C#
            string dados = "Este texto deve ser armazenado em um arquivo.";
            // cria um arquivo para salvar os dados
            FileStream fs = new FileStream( "Serializacao.Data", FileMode.Create);
            // Cria um objeto BinaryFormatter para realizar a serialização
            BinaryFormatter bf = new BinaryFormatter();
            // Usa o objeto BinaryFormatter para serializar os dados para o arquivo
            bf.Serialize(fs, dados);
            // Fecha o arquivo
            fs.Close();
            //Aguarda o pressionamento de uma tecla para encerrar
            Console.WriteLine("Arquivo serializado !");
        }
    }
}
