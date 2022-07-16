using System;
using System.Globalization;
using System.Collections.Generic;
using ConstasBancarias.Entidades;

namespace ConstasBancarias
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> list = new List<Conta>();

            list.Add(new ContaPoupanca(1001, "Alex", 500.00, 0.01));
            list.Add(new ContaNegocios(1002, "Maria", 500.0, 400.0));
            list.Add(new ContaPoupanca(1004, "Bob", 500.0, 0.01));
            list.Add(new ContaNegocios(1005, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Conta acc in list)
            {
                sum += acc.Saldo;
            }

            Console.WriteLine("Saldo Total: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Conta acc in list)
            {
                acc.Saque(10.0);
            }
            foreach (Conta acc in list)
            {
                Console.WriteLine("Saldo atualizado para a conta "
                    + acc.Numero
                    + ": "
                    + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}