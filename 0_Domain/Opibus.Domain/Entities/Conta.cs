using System;

namespace Opibus.Domain.Entities
{
    public class Conta
    {

        public Conta(Cliente cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
        }
        public Cliente Cliente { get; private set; }
        public double Valor { get; private set; }
        public double Saldo { get { return Valor; } }

        public void Depositar(Deposito deposito)
        {
            Valor += deposito.Valor;
        }

        public void Sacar(double valorSaque)
        {
            Valor -= valorSaque;
        }

        public void Transferir(double valor, Conta conta)
        {
            Sacar(valor);
            conta.Depositar(new Deposito(valor, this));
        }
    }
}
