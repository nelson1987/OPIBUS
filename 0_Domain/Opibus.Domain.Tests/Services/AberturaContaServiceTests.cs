using NUnit.Framework;
using Opibus.Domain.Service;

namespace Opibus.Domain.Tests.Services
{
    public class AberturaContaServiceTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AbrirConta()
        {
            var valor = 10.00;
            var nome = "Elias dos Santos";
            var documento = "123.456.789-00";
            var abrirConta = new AberturaContaService(nome, documento, valor);
            Assert.AreEqual(abrirConta.Cliente.Nome, nome);
        }
    }
}
