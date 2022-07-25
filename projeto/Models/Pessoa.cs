namespace CiCd.Models
{
    public class Pessoa
    {
        public Pessoa(int id, string nome, Endereco endereco, bool ativo)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Ativo = ativo;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public Endereco Endereco { get; set; }

        public bool Ativo { get; set; }
    }
}