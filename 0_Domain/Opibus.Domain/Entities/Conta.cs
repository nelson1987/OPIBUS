namespace Opibus.Domain.Entities
{
    public class Conta
    {

        public Conta(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
        }

        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public double Saldo { get { return Valor; } }
    }
}
