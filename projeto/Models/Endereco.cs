namespace CiCd.Models
{
    public class Endereco
    {
        public Endereco(string logradouro, string cidade)
        {
            Logradouro = logradouro;
            Cidade = cidade;
        }

        public string Logradouro { get; set; }

        public string Cidade { get; set; }
    }
}