using System;
using System.Collections.Generic;
using System.Text;

namespace Opibus.Domain.Entities
{
    public class Deposito
    {
        public Conta ContaDeposito { get; private set; }


        public double Valor { get; private set; }
        public string Cpf { get; private set; }

        public Deposito(double valor, string cpf)
        {
            this.Valor = valor;
            this.Cpf = cpf;
        }

        public Deposito(double valor, Conta contaDeposito)
        {
            this.Valor = valor;
            this.ContaDeposito = contaDeposito;
        }
    }
}
