using System;
using System.Globalization;


namespace Saida //namespace
{
    class Program
    {
        static void Main(string[] args) // ent point : inicio do programa. 
        {

            int idade = 39;
            double saldo = 10.35784;
            String nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //Placeholder

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //interpolacao

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
            + saldo.ToString("F2",CultureInfo.InvariantCulture) + " reais"); //cocatenacao

        }

    }
}

