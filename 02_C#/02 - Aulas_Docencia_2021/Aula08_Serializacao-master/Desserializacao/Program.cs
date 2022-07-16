using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Desserializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\lindb\Desktop\Programacao2_2_2021\Projetos\Aula08_Serializacao\Arquivos\Serializacao.Data", FileMode.Open);
            // Cria um objeto BinaryFormatter para realizar a dessarialização
            BinaryFormatter bf = new BinaryFormatter();
            // Cria um objeto para armazenar os dados dessarializados
            string dados = "";
            // Usa o objeto BinaryFormatter para desserializar os dados do arquivo
            dados = (string)bf.Deserialize(fs);
            // fecha o arquivo
            fs.Close();
            // exibe a string desserializada
            Console.WriteLine("Arquivo Desserializado !");
            Console.WriteLine(dados);
        }
    }
}
