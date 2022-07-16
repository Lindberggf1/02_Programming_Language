using System;
using System.Collections.Generic;
using System.Globalization;
using Revisao_10.Entidade;

namespace Revisao_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.Write("Insira o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Produto #" + i + " dados:");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'c')
                {
                    lista.Add(new Produto(nome, preco));
                }
                else if (tipo == 'u')
                {
                    Console.Write("Data de fabricacao (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, data));
                }
                else
                {
                    Console.Write("Taxa Alfandegária: ");
                    double taxaAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(nome, preco, taxaAlfandega));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Etiqueta de Preco:");
            foreach (Produto prod in lista)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
