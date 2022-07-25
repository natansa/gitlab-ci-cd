using CiCd.Models;

namespace CiCdTest.Models
{
    public class PessoaTest
    {
        [Fact]
        public void DEVE_CRIAR_PESSOA_COM_SUCESSO()
        {
            // act
            var pessoa = new Pessoa
            (
                1,
                "Nome da Pessoa",
                new Endereco(string.Empty, string.Empty),
                true
            );

            // assert
            Assert.NotNull(pessoa);
            Assert.True(pessoa.Id > 0);
            Assert.NotEmpty(pessoa.Nome);
            Assert.NotNull(pessoa.Endereco);
            Assert.True(pessoa.Ativo);
        }

        [Fact]
        public void NAO_DEVE_CRIAR_PESSOA_COM_SUCESSO()
        {
            // act
            var pessoa = new Pessoa
            (
                1,
                "Nome da Pessoa",
                null,
                true
            );

            // assert
            Assert.NotNull(pessoa);
            Assert.True(pessoa.Id > 0);
            Assert.NotEmpty(pessoa.Nome);
            Assert.Null(pessoa.Endereco);
            Assert.True(pessoa.Ativo);
        }
    }
}