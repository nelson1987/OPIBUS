using System;

namespace Opibus.Domain.Entities
{
    public class Conta
    {
        private Cliente cliente { get; private set; }
        [Obsolete]
        public Conta(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
        }

        public Conta(Cliente cliente, double valor)
        {
            this.cliente = cliente;
            Valor = valor;
        }

        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public double Saldo { get { return Valor; } }
    }
}
