using NUnit.Framework;
using Opibus.Domain.Entities;

namespace Opibus.Domain.Tests
{
    public class ContaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AbrirConta()
        {
            var cliente = "123.456.789-00";
            var valor = 10.00;
            var conta = new Conta(cliente, valor);
            Assert.AreEqual(conta.Saldo, 10.00);
        }
    }
}