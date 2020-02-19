using NUnit.Framework;
using Opibus.Domain.Entities;

namespace Opibus.Domain.Tests
{
    public class ContaTests
    {
        private Conta _Conta { get; set; }
        [SetUp]
        public void Setup()
        {
            var cliente = new Cliente("Marcos Silva", "123.456.789-00");
            var valor = 10.00;
            _Conta = new Conta(cliente, valor);

        }

        [Test]
        public void AbrirConta()
        {
            Assert.AreEqual(_Conta.Saldo, 10.00);
        }
        [Test]
        public void DepositarNaConta()
        {
            var deposito = new Deposito(10.00, "987.654.321-00");
            _Conta.Depositar(deposito);
            Assert.AreEqual(_Conta.Saldo, 20.00);

        }
    }
}