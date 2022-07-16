using System;
using System.Globalization;

namespace Revisao_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int quartos;
            double preco;
            string[] nomeIdadeAltura;
            string ultimoNome;
            int idade;
            double altura;

            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Entre com seu nome completo: ");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu nome completo: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu nome completo: ");
            nomeIdadeAltura = Console.ReadLine().Split(); //server para quebrar em pedaços a frase.

            ultimoNome = nomeIdadeAltura[0];
            idade = int.Parse(nomeIdadeAltura[1]);
            altura = double.Parse(nomeIdadeAltura[2], CultureInfo.InvariantCulture);


            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
