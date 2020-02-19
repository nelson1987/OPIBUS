using NUnit.Framework;
using Opibus.Domain.Entities;

namespace Opibus.Domain.Tests
{
    public class ClienteTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AbrirConta()
        {
            var nome = "Elias dos Santos";
            var documento = "123.456.789-00";
            var cliente = new Cliente(nome, documento);
            Assert.AreEqual(cliente.Nome, nome);
        }
    }
}
