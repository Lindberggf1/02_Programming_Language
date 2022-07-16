
namespace ConstasBancarias.Entidades
{
    class ContaNegocios : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaNegocios()
        {
        }

        public ContaNegocios(int numero, string titular, double saldo, double limiteEmprestimo)
            : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Loan(double quantia)
        {
            if (quantia <= LimiteEmprestimo)
            {
                Saldo += quantia;
            }
        }
    }
}
