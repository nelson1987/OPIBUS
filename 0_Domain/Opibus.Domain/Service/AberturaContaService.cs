using Opibus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opibus.Domain.Service
{
    public class AberturaContaService
    {
        public AberturaContaService(string nome, string documento, double valor)
        {
            Nome = nome;
            Documento = documento;
            Valor = valor;
        }
        private string Nome { get; set; }
        private string Documento { get; set; }
        private double Valor { get; set; }
        public Cliente Cliente { get { return new Cliente(Nome, Documento); } }
        public Conta Conta { get { return new Conta(Cliente, Valor); } }
    }
}
