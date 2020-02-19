namespace Opibus.Domain.Entities
{
    public class Cliente
    {

        public Cliente(string nome, string documento)
        {
            Nome = nome;
            Documento = documento;
        }
        public string Nome { get; private set; }
        public string Documento { get; private set; }
    }
}
