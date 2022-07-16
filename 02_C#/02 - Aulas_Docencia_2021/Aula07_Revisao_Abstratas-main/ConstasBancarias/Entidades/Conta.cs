
namespace ConstasBancarias.Entidades
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public void Deposit(double quantia)
        {
            Saldo += quantia;
        }
    }
}
